using DatabaseConnection;
using NewBank.Model;
using System;
using NewBank.Common;
using NewBank.Core.Abstraction;

namespace NewBank.Core.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        DataContext _context = GlobalConfig.DbContextInstance;
        public void CreateDataBase() {

            _context.Database.EnsureCreated();
        }
        //adds a new customer
        public string AddCustomer(string firstName, string secondName, string email, string password, string accountType)
        {
            Account account = new Account() {AccountType = accountType};
            Customer customer = new Customer()
            {
                FirstName = Utilities.FirstCharacterToUpper(Utilities.RemoveDigitFromStart(firstName)),
                LastName = Utilities.FirstCharacterToUpper(Utilities.RemoveDigitFromStart(secondName)),
                
                Email = email,
                Password = password,
                AccountId = account.AccountId
            };
            customer.AccountList.Add(account);
            _context.Add(customer);
            _context.SaveChanges();
           return account.AccountNumber;
        }
       
        public void DeleteCustomer()
        {
            throw new NotImplementedException();
        }

        
    }
}
