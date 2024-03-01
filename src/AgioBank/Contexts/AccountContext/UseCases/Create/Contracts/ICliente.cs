using AgioBank.Contexts.AccountContext.Entities;

namespace AgioBank.Contexts.AccountContext.UseCases.Create.Contracts
{
    public interface ICliente
    {
        public Task<Response> CriarConta(Conta conta, CancellationToken cancellationToken);

    }
}
