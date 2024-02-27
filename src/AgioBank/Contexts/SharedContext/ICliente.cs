using System.Diagnostics.CodeAnalysis;

namespace AgioBank.Contexts.SharedContext
{
    public interface ICliente
    {

        public Task<Response> PostAsync(string endPoint, StringContent content, CancellationToken cancellationToken);
    }
}
