using AgioBank.Contexts.AccountContext.Entities;
using System.Net;
using System.Text.Json;
using Create = AgioBank.Contexts.AccountContext.UseCases.Create;
using Authenticate = AgioBank.Contexts.AccountContext.UseCases.Authenticate;
using System.Text;
using System.Net.Http;

namespace AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts
{
    public class Cliente : ICliente
    {
        private readonly HttpClient _clienteHttp;
        public Cliente(IHttpClientFactory clienteHttp)
        {
            _clienteHttp = clienteHttp.CreateClient("api");
        }

        public async Task<Authenticate.Response> Autenticar(string email, string senha, CancellationToken cancellationToken)
        {
            var endPoint = "api/v1/login";

            var content = JsonSerializer.Serialize(new { email, senha });            
            try
            {
                var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
                var httpResponse = await _clienteHttp.PostAsync(endPoint, httpContent);
                httpResponse.EnsureSuccessStatusCode();
                var stringResponse = await httpResponse.Content.ReadAsStreamAsync();
                var responseData = await JsonSerializer.DeserializeAsync<Authenticate.ResponseData>(stringResponse);

                return new Authenticate.Response("Login efetuado com sucesso", responseData!);
            }
            catch (HttpRequestException ex)
            {
                return new Authenticate.Response($"Erro ao autenticar: {ex.Message}", ex.StatusCode == null ? HttpStatusCode.BadRequest : (HttpStatusCode)ex.StatusCode!);
            }
            catch (Exception ex)
            {
                return new Authenticate.Response($"Erro desconhecido: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

    }
}
