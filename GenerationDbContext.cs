using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_C_.Generation;
using Microsoft.EntityFrameworkCore;

namespace Assignment1_C_
{
    public class GenerationDbContext : DbContext
    {
        //public DbSet<>
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Truck> Trucks { get; set; }


        // Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMEDSHAABAN;database=GenerationDatabase;trusted_connection=true;trustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Car>().HasBaseType<Vehicle>();
            //modelBuilder.Entity<Truck>().HasBaseType<Vehicle>();

            modelBuilder.Entity<Vehicle>()
                .HasDiscriminator<string>("VehicleType")
                .HasValue<Car>("Car")
                .HasValue<Truck>("Truck");

        }
    }
}
