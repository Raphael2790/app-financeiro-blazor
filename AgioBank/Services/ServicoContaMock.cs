using AgioBank.Models;

namespace AgioBank.Services
{
    public class ServicoContaMock : IServicoConta
    {
        public async Task<ResultadoConta> CreateAccount(Conta account)
        {
            await Task.Delay(1000);
            return new ResultadoConta {Success = true, Message = "Conta criada com sucesso" };
        }
    }
}
