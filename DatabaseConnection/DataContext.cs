using Microsoft.EntityFrameworkCore;
using NewBank.Model;
using System;
using System.IO;
using System.Reflection;

namespace DatabaseConnection
{
    public class DataContext : DbContext

    {

        //public DataContext(DbContextOptionsBuilder<DataContext> builder) : base(builder.Options)
        //{
        //    Database.EnsureCreated();
        //}



       

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
                //optionsBuilder.UseInMemoryDatabase("");
            optionsBuilder.UseSqlite(@"DataSource=C:\Users\hp\source\repos\NewBankProject\DatabaseConnection\NewBank.db");
            
        
        }
    }
}
