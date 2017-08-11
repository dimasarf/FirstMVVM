using FirstMVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVVM.Repositories
{
    public class AccountRepositories
    {
        readonly SQLiteAsyncConnection _accountDb;

        public AccountRepositories(string FileName)
        {
            _accountDb = new SQLiteAsyncConnection(FileName);
            _accountDb.CreateTableAsync<Account>().Wait();
        }

        public Task<List<Account>> GetAccounts()
        {
            return _accountDb.Table<Account>().ToListAsync();
        }

        public Task<int> CreateAccount(Account account)
        {
            return _accountDb.InsertAsync(account);
        }

        public Task<int> UpdatePassword(Account account)
        {
            return _accountDb.UpdateAsync(account);
        }

        public Task<Account> Login(string Username, string Password)
        {
            var account = _accountDb.Table<Account>().Where(a => a.Username == Username && a.Password == Password).FirstAsync();
            
            if (account != null)
                return account;
            else
                throw new ArgumentException("Invalid Account Credentials");
        }
    }
}
