using DatabaseConnection;
using Microsoft.EntityFrameworkCore;
using NewBank.Core.Abstraction;
using NewBank.Data;
using NewBank.Model;
using System.Collections.Generic;
using System.Linq;

namespace NewBank.Core.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _context;
        public AccountRepository()
        {
         _context = GlobalConfig.DbContextInstance;
        }
        //get customer by account number
        public Account GetAccount(string accountNumber)
        {
            return _context.Accounts.FirstOrDefault(x => x.AccountNumber == accountNumber);
        }
        // check if account exists
        public bool AccountExist(string accountNumber)
        {
            var result = _context.Accounts.FirstOrDefault(x => x.AccountNumber == accountNumber);

            return result != null? true : false;
        }
        
        public IEnumerable<string> FetchCustAccNums(string email)
        {
           return _context.Accounts.Where(x => x.Customers.Email == email).Select(x => x.AccountNumber).ToList();
        }
        public IEnumerable<decimal> AccountBalance(string accountnum)
        {
            return _context.Accounts.Where(x => x.AccountNumber == accountnum).Select(x => x.Balance).ToList();
        }


    }
}
