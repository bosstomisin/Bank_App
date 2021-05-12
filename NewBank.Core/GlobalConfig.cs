using DatabaseConnection;
using Microsoft.EntityFrameworkCore;
using NewBank.Core;
using NewBank.Core.Abstraction;
using NewBank.Core.Interface;
using NewBank.Core.Repository;
//using NewBank.Data.Implementation;

namespace NewBank.Core
{
    public static class GlobalConfig
    {
       public static IBankOperations BankOp { get; set; }

        public static DataContext DbContextInstance { get; set; }

        public static ICustomerRepository CustoRepo { get; set; }
        public static IAccountRepository AccountRepo { get; set; }



        public static IAuth _auth { get; set; }
        public static void AddInstance()
        {
            //var options = new DbContextOptionsBuilder<DataContext>().UseSqlite(@"Data Source = C:\Users\hp\source\repos\NewBankProject\DatabaseConnection\NewBank.db");
            DbContextInstance = new DataContext();
            CustoRepo = new CustomerRepository();
            AccountRepo = new AccountRepository();
            BankOp = new BankOperations(AccountRepo);
            _auth = new Auth();
        }
    }
}
