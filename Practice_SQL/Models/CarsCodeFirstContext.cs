using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Practice_SQL.Models
{
    public partial class CarsCodeFirstContext : DbContext
    {
        public CarsCodeFirstContext()
        {
        }
        public CarsCodeFirstContext(DbContextOptions<CarsCodeFirstContext>options) : base(options)
        {

        }
        // Called when we're configuring a database connection.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // If we aren't already configured.
            if (!optionsBuilder.IsConfigured)
            {
                // Initialize the connection to a MySQL server.
                optionsBuilder
                   .UseMySql("server=localhost;port=3306;user=root;database=code_first_cars",
                       // Retreived from PHPMyAdmin under Home > Database Server > Server Version.
                       x => x.ServerVersion("10.4.14-MariaDB"));

                /*
                    Connection strings are used to define an entire connection profile in one string. They are composed of attributes and values separated by semicolons.
                    
                    server=VALUE - Declares the server address for the connection.
                    port=VALUE - Declares the port for the conenction.
                    user=VALUE - Declares the database username for the connection.
                    password=VALUE - Declares that username's password for the connection (if applicable).
                    database=VALUE - Declares the database name to connect to.
                */

                // server=localhost;port=3306;user=root;database=code_first_cars
            }
        }

        // Called when we're doing database migrations, etc.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {// Declare advanced column configuration for our model.
            modelBuilder.Entity<CodeFirstCar>(entity =>
            {
                // If you have foreign keys, declare them here as "HasIndex".

                // Declare the string encoding for our text fields.
                entity.Property(e => e.Manufacturer)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                // PLEASE don't try to memorize this. Copy/paste it and change the column name.
                entity.Property(e => e.Model)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TrimLevel)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Colour)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            // Call the partial method in case we add some stuff to another file later.
            OnModelCreatingPartial(modelBuilder);


            // Call the partial method in case we add some stuff to another file later.
            OnModelCreatingPartial(modelBuilder);
        }

        // Not technically needed, but the scaffolding generates it for later use, so we can add it if we want for future-proofing.
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
      
}
