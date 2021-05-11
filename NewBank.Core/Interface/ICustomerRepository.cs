using NewBank.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBank.Core.Abstraction
{
    public interface ICustomerRepository
    {
        public void CreateDataBase();
        public string AddCustomer(string firstName, string secondName, string email, string password, string accountType);
        public void DeleteCustomer();
    }
}
