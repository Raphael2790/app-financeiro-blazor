using AgioBank.Models;

namespace AgioBank.Services
{
    public class AccountServiceMock : IAccountService
    {
        public async Task<AccountResult> CreateAccount(Account account)
        {
            await Task.Delay(1000);
            return new AccountResult { Token = "12345", Success = true, Message = "Conta criada com sucesso" };
        }
    }
}
