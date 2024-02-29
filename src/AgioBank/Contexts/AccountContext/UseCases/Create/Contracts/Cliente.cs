using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Contexts.SharedContext;
using System.Net;
using System.Text.Json;
using Create = AgioBank.Contexts.AccountContext.UseCases.Create;

namespace AgioBank.Contexts.AccountContext.UseCases.Create.Contracts
{
    public class Cliente : ClienteApi
    {
        public Cliente(HttpClient cliente) : base(cliente)
        {
        }

        public async Task<Response> CriarConta(Conta conta, CancellationToken cancellationToken)
        {
            var endpoint = "api/v1/accounts";

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

                    var httpResponse = await base.PostAsync(endpoint, content, cancellationToken);

                    var responseContent = await httpResponse.Content.ReadAsStreamAsync();
                    var responseData = await JsonSerializer.DeserializeAsync<ResponseData>(responseContent);

                    return new Create.Response("Conta criada com sucesso", responseData!);
                }

            }
            catch (HttpRequestException ex)
            {
                return new Create.Response($"Erro ao criar conta: {ex.Message}", (HttpStatusCode)ex.StatusCode!);
            }
            catch (Exception ex)
            {
                return new Create.Response($"Erro desconhecido: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
    }
}
