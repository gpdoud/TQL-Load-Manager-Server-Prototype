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

        public DbSet<LoadManagerPrototype.Models.Driver> Driver { get; set; }

        public DbSet<LoadManagerPrototype.Models.Dispatcher> Dispatcher { get; set; }

        public DbSet<LoadManagerPrototype.Models.Commodity> Commodity { get; set; }

        public DbSet<LoadManagerPrototype.Models.Delivery> Delivery { get; set; }

        public DbSet<LoadManagerPrototype.Models.Pickup> Pickup { get; set; }

        public DbSet<LoadManagerPrototype.Models.CommodityDelivery> CommodityDelivery { get; set; }

        public DbSet<LoadManagerPrototype.Models.CommodityPickup> CommodityPickup { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasIndex(p => p.Username).IsUnique();
            builder.Entity<Carrier>().HasIndex(p => p.McNumber).IsUnique();
        }
    }

}
