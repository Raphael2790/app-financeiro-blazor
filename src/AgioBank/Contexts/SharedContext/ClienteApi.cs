namespace AgioBank.Contexts.SharedContext
{
    public abstract class ClienteApi
    {
        private readonly HttpClient _clienteHttp;

        public ClienteApi(HttpClient cliente) => _clienteHttp = cliente;
        public async Task<HttpResponseMessage> PostAsync(string endPoint, HttpContent content, CancellationToken cancellationToken)
        {
            try 
            {
                var httpResponse = await _clienteHttp.PostAsync(endPoint, content, cancellationToken);
                httpResponse.EnsureSuccessStatusCode();
                return httpResponse;
            }
            catch
            {
                throw;
            }
        }
    }
}
