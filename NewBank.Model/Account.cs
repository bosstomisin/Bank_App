using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NewBank.Model
{
    public class Account
    {
        public Account()
        {
            string startWith = "3216";
            Random generator = new Random();
            string r = generator.Next(0, 999999).ToString("D6");
            AccountNumber = startWith + r;

            AccountId = Guid.NewGuid().ToString();
            TransactionHistory = new List<Transaction>();
        }
        [Key]
        public string AccountId { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; } 

        [ForeignKey("CustomerId")]
        public string CustomerId { get; set; }
        public Customer Customers { get; set; }
        [ForeignKey("TransactionId")]
        public string TransactionId { get; set; }
        public List<Transaction> TransactionHistory { get; set; }
    }   
}
