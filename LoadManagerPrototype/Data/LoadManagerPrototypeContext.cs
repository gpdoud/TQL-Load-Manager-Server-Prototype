using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoadManagerPrototype.Models;

namespace LoadManagerPrototype.Data
{
    public class LoadManagerPrototypeContext : DbContext
    {
        public LoadManagerPrototypeContext (DbContextOptions<LoadManagerPrototypeContext> options)
            : base(options)
        {
        }

        public DbSet<LoadManagerPrototype.Models.Carrier> Carrier { get; set; }

        public DbSet<LoadManagerPrototype.Models.Customer> Customer { get; set; }

        public DbSet<LoadManagerPrototype.Models.Load> Load { get; set; }

        public DbSet<LoadManagerPrototype.Models.Shed> Shed { get; set; }

        public DbSet<LoadManagerPrototype.Models.User> User { get; set; }
    }
}
