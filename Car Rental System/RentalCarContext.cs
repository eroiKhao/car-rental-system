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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Car>()
                .Property(c => c.PricePerDay)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalPrice)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Client)
                .HasForeignKey(o => o.ClientID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.RentedCar)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CarID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
    }

