using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Wastelander.Models;

namespace Wastelander.Models
{
    public class WastelanderContext : IdentityDbContext<ApplicationUser>
    {
        public WastelanderContext()
        {

        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Zombie> Zombies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Wastelander;integrated security=True");
        }
        public WastelanderContext(DbContextOptions<WastelanderContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
