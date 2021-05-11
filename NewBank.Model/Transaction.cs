using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewBank.Model
{
    public class Transaction
    {
        public Transaction()
        {
            TransactionId = Guid.NewGuid().ToString();
            Date = DateTime.Now;
        }
        [Key]
        public string TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public string AccountNumber { get; set; }
        public string TransactionType { get; set; }
        public string AccountId { get; set; }

        [ForeignKey("AccountId")]
        public Account Account  { get; set; }



    }
}
