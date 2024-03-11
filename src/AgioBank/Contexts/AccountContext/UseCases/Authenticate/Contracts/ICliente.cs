using AgioBank.Contexts.AccountContext.Entities;

namespace AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts
{
    public interface ICliente
    {
        public Task<AgioBank.Contexts.AccountContext.UseCases.Authenticate.Response> Autenticar(string email, string senha, CancellationToken cancellationToken);
    }
}
