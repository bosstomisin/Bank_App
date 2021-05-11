using System;
using System.Collections.Generic;
using System.Text;

namespace NewBank.Core2
{
    public interface IBankOperation2
    {
        
            public void Deposit(string accnum, decimal amount, string note);
            public void Withdraw(string accnum, decimal amount, string note);
            public void Transfer(string depositorAccnum, string creditorAccount, decimal amount, string note);


        
    }
}
