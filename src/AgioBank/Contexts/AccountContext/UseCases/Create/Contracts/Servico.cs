using AgioBank.Contexts.AccountContext.Entities;
using System.Net;
using System.Text;
using System.Text.Json;

namespace AgioBank.Contexts.AccountContext.UseCases.Create.Contracts
{
    public class Servico : IServico
    {
        private readonly HttpClient _client;

        public Servico(HttpClient client) => _client = client;

        public async Task<Response> CriarConta(Conta conta, CancellationToken cancellationToken)
        {
            try
            {
                var endpoint = "api/v1/accounts";

                var content = new StringContent(JsonSerializer.Serialize(conta), Encoding.UTF8, "application/json");

                var httpResponse = await _client.PostAsync(endpoint, content, cancellationToken);

                httpResponse.EnsureSuccessStatusCode();
                var responseContent = await httpResponse.Content.ReadAsStringAsync();
                var responseData = JsonSerializer.Deserialize<ResponseData>(responseContent);

                return new Response("Conta criada com sucesso", responseData!);
            }
            catch (HttpRequestException ex)
            {
                return new Response($"Erro de solicitação HTTP: {ex.Message}", (HttpStatusCode)ex.StatusCode!);
            }
            catch
            {
                return new Response("Erro desconhecido ao criar conta", HttpStatusCode.InternalServerError);
            }
        }
    }
}
