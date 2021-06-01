using DatabaseConnection;
using NewBank.Core;
using NewBank.Core.Abstraction;
using NewBank.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NewBank.Test
{
    public class CustomerRepositoryTest : DataContextBase
    {
        public ICustomerRepository ConfigInstance()
        {
            GlobalConfig.AddInstance();

            return GlobalConfig.CustoRepo;
        }
        [Fact]
        public void AddCustomerTest()
        {
            var custoRepo = ConfigInstance();
            //arrange
        
            var expected = "3216";

            //act
            var actual = custoRepo.AddCustomer("John", "val", "val@gmail.com", "123", "savings");

            //assert
            Assert.Contains(expected, actual);
        }
        
       

    }
}
