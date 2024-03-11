
using AgioBank.Contexts.SharedContext;

namespace AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts
{
    public class Servico : IServico
    {
        private readonly ICliente _cliente;

        public Servico(ICliente cliente)
        {
            _cliente = cliente;
        }

        public async Task<Response> Autenticar(string email, string senha, CancellationToken cancellationToken)
        {
            var response = await _cliente.Autenticar(email, senha, cancellationToken);
            return response;
        }
    }
}
