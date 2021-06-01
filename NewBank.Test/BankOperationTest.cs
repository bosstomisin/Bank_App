using DatabaseConnection;
using NewBank.Core;
using NewBank.Core.Abstraction;
using NewBank.Core.Repository;
using Xunit;

namespace NewBank.Test
{

    public class BankOperationTest : DataContextBase
    {
        public IBankOperations ConfigInstance()
        {
            GlobalConfig.AddInstance();

            return GlobalConfig.BankOp;
        }

        [Fact]
        public void Deposit_Returns_Flag()
        {
            var bankOperations = ConfigInstance();

            //arrange
            string accountNumber = "365111";
            decimal amount = -14;

            decimal amountTw0 = 12;
            string note = "transfer";


            //act
            var transaction = bankOperations.Deposit(accountNumber, amount, note);
            var transactionTwo = bankOperations.Deposit(accountNumber, amountTw0, note);

            //assert
            Assert.False(transaction);
            Assert.True(transactionTwo);
        }

        [Fact]
        public void Withdrawal_Returns_Flag()
        {
            var bankOperations = ConfigInstance();
            //arrange
            string accountNumber = "365111";
            string accountNumberTwo = "365111";
            string accountNumberThree = "365112";
            decimal amount = 10;
            decimal amountTwo = 450;
            decimal amountThree = 2050;
            string note = "";


            //act
            var checkSavingsAccountNumber = bankOperations.Withdraw(accountNumberTwo, amountTwo, note);
            var checkCurrentAccountNumber = bankOperations.Withdraw(accountNumberThree, amountThree, note);
            var withdraw = bankOperations.Withdraw(accountNumber, amount, note);

            //assert
            Assert.True(withdraw);
            Assert.False(checkSavingsAccountNumber);
            Assert.False(checkCurrentAccountNumber);

        }

        [Fact]
        public void Transfer_Return_Flag()
        {
            var bankOperations = ConfigInstance();
            //arrange
            string depositorAccountNumber = "365111";
            string creditorAccountNumber = "365112";
            string falseAccountNumber = "945";
            decimal amount = 345;
            string note = "";
            string accountNumber1 = "365111";
            string accountNumber2 = "365111";

            //act
            var transfer = bankOperations.Transfer(depositorAccountNumber, creditorAccountNumber, amount, note);
            var transferTwo = bankOperations.Transfer(depositorAccountNumber, falseAccountNumber, amount, note);
            var checkifsameaccount = bankOperations.Transfer(accountNumber1, accountNumber2, amount, note);



            //assert
            Assert.True(transfer);
            Assert.False(transferTwo);
            Assert.False(checkifsameaccount);
        }
    }
}
