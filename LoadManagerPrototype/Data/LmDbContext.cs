using LoadManagerPrototype.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Data
{
    public class LmDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Shed> Sheds { get; set; }
        public DbSet<Load> Loads { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Carrier> Carriers { get; set; }

        public LmDbContext(DbContextOptions<LmDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(u => { u.HasIndex(u => u.Username).IsUnique(); });
            builder.Entity<Load>(l => { l.HasIndex(l => l.PoNumber).IsUnique(); });
        }
    }
}
