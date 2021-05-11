using System;
using System.Collections.Generic;
using System.Text;

namespace NewBank.Core.Interface
{
    public interface IAuth
    {
        public bool CheckEmailExist(string email);
        public bool CheckPasswordExist(string password);

    }
}
