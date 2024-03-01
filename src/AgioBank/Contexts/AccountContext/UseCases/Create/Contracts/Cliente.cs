using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Contexts.SharedContext;
using System.Net;
using System.Text.Json;
using Create = AgioBank.Contexts.AccountContext.UseCases.Create;

namespace AgioBank.Contexts.AccountContext.UseCases.Create.Contracts
{
    public class Cliente : ICliente
    {
        private readonly HttpClient _clienteHttp;

        public Cliente(HttpClient clienteHttp) => _clienteHttp = clienteHttp;

        public async Task<Response> CriarConta(Conta conta, CancellationToken cancellationToken)
        {
            var endPoint = "api/v1/accounts";

            var jsonConta = JsonSerializer.Serialize(new
            {
                conta.Nome,
                conta.Sobrenome,
                conta.Telefone,
                conta.Email,
                conta.Documento,
                conta.NomeMae,
                conta.Senha
            });

            var content = new MultipartFormDataContent
            {
                { new StringContent(jsonConta), "conta" }
            };

            try
            {
                using (conta.Arquivo)
                {
                    content.Add(conta.Arquivo!, "arquivo", conta.NomeArquivo);

                    var httpResponse = await _clienteHttp.PostAsync(endPoint, content, cancellationToken);
                    httpResponse.EnsureSuccessStatusCode();

                    var responseContent = await httpResponse.Content.ReadAsStreamAsync();
                    var responseData = await JsonSerializer.DeserializeAsync<ResponseData>(responseContent);

                    return new Create.Response("Conta criada com sucesso", responseData!);
                }

            }
            catch (HttpRequestException ex)
            {
                return new Create.Response($"Erro ao criar conta: {ex.Message}", ex.StatusCode == null? HttpStatusCode.BadRequest : (HttpStatusCode)ex.StatusCode!);
            }
            catch (Exception ex)
            {
                return new Create.Response($"Erro desconhecido: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
    }
}
