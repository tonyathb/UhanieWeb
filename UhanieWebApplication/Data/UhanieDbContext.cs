using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UhanieWebApplication.Data
{
    public class UhanieDbContext : IdentityDbContext<Customer>
    {
        public UhanieDbContext(DbContextOptions<UhanieDbContext> options)
            : base(options)
        {
        }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Bouquet> Bouquets { get; set; }
        //public DbSet<Role> Roles { get; set; }
        public DbSet<OrderFlower> OrderFlowers { get; set; }
        public DbSet<OrderBouquet> OrderBouquets { get; set; }
    }
}
