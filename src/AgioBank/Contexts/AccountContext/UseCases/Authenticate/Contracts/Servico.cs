
namespace AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts
{
    public class Servico : IServico
    {
        public Task<Response> Autenticar(string email, string senha, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
