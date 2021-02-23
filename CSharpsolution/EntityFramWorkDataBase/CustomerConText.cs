using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramWorkDataBase
{
    class CustomerConText :DbContext

    { 
        private readonly string _connectionstring;

        private readonly string _assemblyName;
        public CustomerConText(string connectionstring, string assemblyName)
        {
            _connectionstring = connectionstring;
            _assemblyName = assemblyName;

        }
        public CustomerConText()
        {
            _connectionstring = ConnectionInfo .ConnectionString;
            _assemblyName = typeof(Program).Assembly.FullName;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionstring,
                    m => m.MigrationsAssembly(_assemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
