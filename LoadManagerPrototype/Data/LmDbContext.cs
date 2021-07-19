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

        public LmDbContext(DbContextOptions<LmDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder bulider)
        {

        }
    }
}
