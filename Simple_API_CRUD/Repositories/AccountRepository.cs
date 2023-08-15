using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simple_API_CRUD.Data;
using Simple_API_CRUD.Models;

namespace Simple_API_CRUD.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DbContextClass _dbContext;

        public AccountRepository(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AccountDetails> AddAccountAsync(AccountDetails accountDetails)
        {
            var result = _dbContext.Accounts.Add(accountDetails);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteAccountAsync(int Id)
        {
            var filteredData = _dbContext.Accounts.Where(x => x.Id == Id).FirstOrDefault();
            _dbContext.Accounts.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<AccountDetails> GetAccountByIdAsync(int Id)
        {
            return await _dbContext.Accounts.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<AccountDetails>> GetAccountListAsync()
        {
            return await _dbContext.Accounts.ToListAsync();
        }

        public async Task<int> UpdateAccountAsync(AccountDetails accountDetails)
        {
            _dbContext.Accounts.Update(accountDetails);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
