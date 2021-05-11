using System;
using DatabaseConnection;
using NewBank.Model;
using System.Linq;

//using NewBank.Data.Implementation;
using NewBank.Core.Abstraction;
using System.Collections.Generic;

namespace NewBank.Core
{
    public class BankOperations : IBankOperations
    {
        private readonly DataContext _context;
        private readonly IAccountRepository _accountRepo;
        public BankOperations(IAccountRepository accountRepo)
        {
            _context = GlobalConfig.DbContextInstance;
            _accountRepo = accountRepo;
        }
        // make deposit
        public bool Deposit(string accnum, decimal amount, string note)
        {
            var userAccountId = _context.Accounts.FirstOrDefault(x => x.AccountNumber == accnum).AccountId;
            if (amount <= 0)
            {
                return false;
            }
            else
            {
                Transaction transaction = new Transaction{ AccountNumber = accnum, Amount = amount, TransactionType = "Deposit", Notes = note, AccountId =userAccountId };
                _context.Transactions.Add(transaction);
                _accountRepo.GetAccount(accnum).Balance += amount;
                _context.SaveChanges();
                return true;
            }
        }
        //make withdrawl
        public bool Withdraw(string accnum, decimal amount, string note)
        {
            var userAccountId = _context.Accounts.FirstOrDefault(x => x.AccountNumber == accnum).AccountId;

            if (_accountRepo.GetAccount(accnum).AccountType == "Savings")
            {
                if ((_accountRepo.GetAccount(accnum).Balance - amount) < 1000)
                {
                    return false;
                }
            }
            else
            {
                if ((_accountRepo.GetAccount(accnum).Balance - amount) < 0)
                {
                    //throw new InvalidOperationException("Insufficient Fund");
                    return false;
                }
            }
            var transaction = new Transaction() { AccountNumber = accnum, Amount = amount, Notes = note, TransactionType = "Withdrawal", AccountId = userAccountId };
            _context.Transactions.Add(transaction);
            _accountRepo.GetAccount(accnum).Balance -= amount;
            _context.SaveChanges();
            return true;
        }
        //make transfer
        public bool Transfer(string depositorAccnum, string creditorAccount, decimal amount, string note)
        {
            if (depositorAccnum == creditorAccount)
            {
                return false;

            }
            if (!_accountRepo.AccountExist(creditorAccount))
            {
                return false;
            }
            Withdraw(depositorAccnum, amount, note);
            Deposit(creditorAccount, amount, note);
            return true;
        }
        //displays list of all transaction
        public List<Transaction> StatementOfAccount(string accountNumber)
        {
            return _context.Transactions.Where(x => x.AccountNumber == accountNumber).ToList();
        }
    }
}
