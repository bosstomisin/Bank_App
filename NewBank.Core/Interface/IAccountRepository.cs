using NewBank.Model;
using System.Collections.Generic;

namespace NewBank.Core.Abstraction
{
    public interface IAccountRepository
    {
        public Account GetAccount(string accountNumber);
        public bool AccountExist(string accountNumber);

        public IEnumerable<string> FetchCustAccNums(string email);


    }
}
