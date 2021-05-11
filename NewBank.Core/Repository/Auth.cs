using DatabaseConnection;
using NewBank.Core.Abstraction;
using NewBank.Core.Interface;
using NewBank.Data;
using System.Linq;

namespace NewBank.Core.Repository
{
    public class Auth : IAuth
    {
        private static readonly DataContext _context = GlobalConfig.DbContextInstance;
        private readonly ICustomerRepository _customerRepository;
        public Auth()
        {

        }
        public Auth(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;

        }
        public bool CheckEmailExist(string email)
        {
           return  _context.Customers.Any(x => x.Email == email);
            
        }

        public bool CheckPasswordExist(string password)
        {
           return  _context.Customers.Any(x => x.Password == password);
        }

     

    }
}
