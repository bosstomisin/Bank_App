//using DatabaseConnection;
//using NewBank.Core;
//using NewBank.Core.Abstraction;
//using NewBank.Model;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace NewBank.Test
//{
//    public class CustomerRepositoryTest : DataContextBase
//    {
//        public ICustomerRepository ConfigInstance()
//        {
//            GlobalConfig.AddInstance();

//            return GlobalConfig.CustoRepo;
//        }
//        public void AddCustomerTest()
//        {
//            var custoRepo = ConfigInstance();
//            //arrange
//            var acount = new Account() { AccountType = "Savings" };
//            var customer = new Customer()
//            {

//                FirstName = "2john",
//                LastName = "jack",
//                Email = "a@gmail.com",
//                Password = "123",
//            };
//            customer.AccountList.Add(acount);
//            var expected = custoRepo.Add(customer);

//            //act
//            var actual = custoRepo.AddCustomer(firstName, secondName, email, password, type, accountType);

//            //assert
//            Assert.true(addCustomer);
//        }
//    }
//}
