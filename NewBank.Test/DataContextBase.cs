using DatabaseConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace NewBank.Test
{
    public class DataContextBase : IDisposable
    {
        private readonly DataContext _context = new DataContext();
        public DataContextBase()
        {

            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context.Database.EnsureCreated();

            DataContextInitializer.Initialize(_context);
        }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
        
    }
}
