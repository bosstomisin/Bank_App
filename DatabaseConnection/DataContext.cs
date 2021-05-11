using Microsoft.EntityFrameworkCore;
using NewBank.Model;
using System;
using System.IO;
using System.Reflection;

namespace DatabaseConnection
{
    public class DataContext : DbContext

    {
        //public static string workingDirectory = Environment.CurrentDirectory;
        //public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        //public DbSet<AccountType> AccountTypes  { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\hp\source\repos\NewBankProject\DatabaseConnection\NewBank.db");
        
        }
    }
}
