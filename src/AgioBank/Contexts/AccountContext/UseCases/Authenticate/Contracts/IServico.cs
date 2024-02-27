namespace AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts
{
    public interface IServico
    {
        Task<Response> Autenticar(string email, string senha, CancellationToken cancellationToken);

    }
}
