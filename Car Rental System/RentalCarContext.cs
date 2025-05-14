using System;
using Microsoft.EntityFrameworkCore;
using Car_Rental_System.Models;
using System.Configuration;

namespace Car_Rental_System
{
    public class RentalCarContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 41));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
