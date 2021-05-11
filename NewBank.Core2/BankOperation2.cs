using DatabaseConnection;
using NewBank.Data;
using NewBank.Data.Abstraction;
using System;

namespace NewBank.Core2
{
   public class BankOperation2 : IBankOperation2
    {
        
            DataContext _context = GlobalConfig.DbContextInstance;
            private readonly IAccountRepository _accountRepo;
            public BankOperations2(IAccountRepository accountRepo)
            {
                _accountRepo = accountRepo;
            }

            public void Deposit(string accnum, decimal amount, string note)
            {
                if (amount <= 0)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    Transaction transaction = new Transaction() { AccountNumber = accnum, Amount = amount, TransactionType = "Deposit", Notes = note };
                    _context.Transactions.Add(transaction);
                    _accountRepo.GetAccount(accnum).Balance += amount;
                    _context.SaveChanges();
                }
            }
            public void Withdraw(string accnum, decimal amount, string note)
            {
                if (_accountRepo.GetAccount(accnum).AccountType == "Savings")
                {
                    if ((_accountRepo.GetAccount(accnum).Balance - amount) < 1000)
                    {
                        throw new InvalidOperationException("Insufficient Fund");
                    }
                }
                else
                {
                    if ((_accountRepo.GetAccount(accnum).Balance - amount) < 0)
                    {
                        throw new InvalidOperationException("Insufficient Fund");
                    }
                }
                var transaction = new Transaction() { AccountNumber = accnum, Amount = amount, Notes = note, TransactionType = "Withdrawal" };
                _context.Transactions.Add(transaction);
                _accountRepo.GetAccount(accnum).Balance -= amount;
                _context.SaveChanges();
            }
            public void Transfer(string depositorAccnum, string creditorAccount, decimal amount, string note)
            {
                //if (_accountRepo.GetAccount(depositorAccnum).AccountType == "Savings") {
                //    if (_accountRepo.GetAccount(depositorAccnum).Balance - amount < 1000)
                //    {
                //        throw new InvalidOperationException("Insufficient Fund");
                //    }
                //}
                //else
                //{
                //    if (_accountRepo.GetAccount(depositorAccnum).Balance - amount < 0)
                //    {
                //        throw new InvalidOperationException("Insufficient Fund");
                //    }
                //}
                if (!_accountRepo.AccountExist(creditorAccount))
                {
                    throw new ArgumentNullException("Account does not exist");
                }
                Withdraw(depositorAccnum, amount, note);
                Deposit(creditorAccount, amount, note);


            }
        
    }

}
