using Simple_API_CRUD.Models;

namespace Simple_API_CRUD.Repositories
{
    public interface IAccountRepository
    {
        public Task<List<AccountDetails>> GetAccountListAsync();
        public Task<AccountDetails> GetAccountByIdAsync(int Id);
        public Task<AccountDetails> AddAccountAsync(AccountDetails accountDetails);
        public Task<int> UpdateAccountAsync(AccountDetails accountDetails);
        public Task<int> DeleteAccountAsync(int Id);
    }
}
