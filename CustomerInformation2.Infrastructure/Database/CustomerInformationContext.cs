using System;
using CustomerInformation2.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformation2.Infrastructure.Database
{
    public class CustomerInformationContext : DbContext
    {
        public CustomerInformationContext(DbContextOptions<CustomerInformationContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
