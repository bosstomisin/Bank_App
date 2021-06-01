using DatabaseConnection;
using NewBank.Model;
using System;
using System.Linq;

namespace NewBank.Test
{
    public class DataContextInitializer
    {
        public static void Initialize(DataContext context)
        {
            if (context.Transactions.Any())
            {
                return;
            }

            if (context.Accounts.Any())
            {
                return;
            }

            if (context.Customers.Any())
            {
                return;
            }

            Seed(context);

        }


        private static void Seed(DataContext context)
        {
            var customers = new Customer[]
{
                new Customer{CustomerId = "ef", AccountId = "", DateCreated = DateTime.Now, Email = "a@gmail.com", FirstName = "John", LastName = "Jack", Password = "123"},
                new Customer{CustomerId = "fg", AccountId = "", DateCreated = DateTime.Now, Email = "b@gmail.com", FirstName = "John", LastName = "jax", Password = "123"},
                new Customer{CustomerId = "gh", AccountId = "", DateCreated = DateTime.Now, Email = "c@gmail.com", FirstName = "John", LastName = "jane", Password = "123"},

};
            context.Customers.AddRange(customers);
            context.SaveChanges();
          
            var accounts = new Account[]
           {
                new Account{AccountId = "ab", AccountNumber = "365111", AccountType = "Savings", Balance = 1110, CustomerId = "ef", TransactionId = "a" },//123
                new Account{AccountId = "bc", AccountNumber = "365112", AccountType = "Current", Balance = 1110, CustomerId = "fg", TransactionId = "b"},//345
                new Account{AccountId = "cd", AccountNumber = "365113", AccountType = "Savings", Balance = 1110, CustomerId = "gh",TransactionId = "c" },//567
           };
           context.Accounts.AddRange(accounts);
            context.SaveChanges();


            var transactions = new Transaction[]
            {
             new Transaction{TransactionId = "a", AccountId= "ab", AccountNumber = "123", Amount = 123, Date = DateTime.Now, Notes = "transfer", TransactionType = "Deposit"},
             new Transaction{TransactionId = "b", AccountId= "bc", AccountNumber = "345", Amount = 123, Date = DateTime.Now, Notes = "transfer", TransactionType = "withdrwal"}   ,
             new Transaction{TransactionId = "c", AccountId= "cd", AccountNumber = "567", Amount = 123, Date = DateTime.Now, Notes = "transfer", TransactionType = "Deposit"}   ,
            };
            context.Transactions.AddRange(transactions);
            context.SaveChanges();

        }
    }
}
