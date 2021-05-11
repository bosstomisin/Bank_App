using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewBank.Model
{
    public class Customer
    {
        public Customer()
        {
            CustomerId = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            AccountList = new List<Account>();
        }
        [Key]
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [ForeignKey("AccountId")]
        public string AccountId { get; set; }
        public DateTime DateCreated { get; set; }

        public List<Account> AccountList { get; set; } 
    }
}
