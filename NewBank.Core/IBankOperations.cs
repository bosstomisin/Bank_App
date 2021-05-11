using NewBank.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBank.Core
{
    public interface IBankOperations
    {
        public bool Deposit(string accnum, decimal amount, string note);
        public bool Withdraw(string accnum, decimal amount, string note);
        public bool Transfer(string depositorAccnum, string creditorAccount, decimal amount, string note);
        public List<Transaction> StatementOfAccount(string accountNumber);


    }
}
