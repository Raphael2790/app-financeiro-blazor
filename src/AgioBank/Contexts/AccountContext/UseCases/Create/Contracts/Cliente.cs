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

        public async Task<SharedContext.Response> PostAsync(string endPoint, StringContent content, CancellationToken cancellationToken)
        {
            try
            {
                var endpoint = "api/v1/accounts";

                var httpResponse = await _clienteHttp.PostAsync(endpoint, content, cancellationToken);

                var responseContent = await httpResponse.Content.ReadAsStreamAsync();
                var responseData = await JsonSerializer.DeserializeAsync<ResponseData>(responseContent);

                return new Create.Response("Operação efetuada com sucesso", responseData!);
            }
            catch (HttpRequestException ex)
            {
                return new Create.Response($"Erro de solicitação HTTP: {ex.Message}", (HttpStatusCode)ex.StatusCode!);
            }
            catch (Exception ex)
            {
                return new Create.Response($"Erro desconhecido: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
    }
}
