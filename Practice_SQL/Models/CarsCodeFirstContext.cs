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

        public CarsCodeFirstContext(DbContextOptions<CarsCodeFirstContext> options) : base(options)
        {

        }

        // These properties allow the context to be read and written to.
        public virtual DbSet<CodeFirstCar> Cars { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }

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
        {
            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasData(
                    new Manufacturer() { ID = 1, Name = "Chevrolet", YearFounded = 1911 },
                    new Manufacturer() { ID = 2, Name = "Ford", YearFounded = 1903 },
                    new Manufacturer() { ID = 3, Name = "Tesla", YearFounded = null },
                    new Manufacturer() { ID = 4, Name = "Dodge", YearFounded = null },
                    new Manufacturer() { ID = 5, Name = "Toyota", YearFounded = 1937 },
                    new Manufacturer() { ID = 6, Name = "Honda", YearFounded = 1946 },
                    new Manufacturer() { ID = 7, Name = "Mitsubishi", YearFounded = null },
                    new Manufacturer() { ID = 8, Name = "Nissan", YearFounded = null }
                    );
            });

            // Declare advanced column configuration for our model.
            modelBuilder.Entity<CodeFirstCar>(entity =>
            {
                // If you have foreign keys, declare them here as "HasIndex".
                entity.HasIndex(e => e.ManufacturerID)
                    .HasName("FK_CodeFirstCar_Manufacturer");

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


                // Enforce the Foreign Key
                // Specify the relationship between the child and parent
                entity.HasOne(child => child.ManufacturerRed)
                // Specify the relationship between the parent and child(ren)
                    .WithMany(parent => parent.Cars)
                // Specify the property acting as the foreign key
                    .HasForeignKey(child => child.ManufacturerID)
                // Specify delete behaviour
                    .OnDelete(DeleteBehavior.Restrict)
                // Name the foreign key
                    .HasConstraintName("FK_CodeFirstCar_Manufacturer");

                // Generate a random set of data for seeding. Note that this method is only run when "dotnet ef migrations add" is run, so therefore the random set of data will persist if a migration is reverted and reapplied. If you want a new dataset, remove the migration and recreate it (AFTER you've rolled back the migration that added it to the database).
                string[] makes = new string[] { "Chevrolet", "Dodge", "Ford" };
                string[] models = new string[] { "Corvette", "Durango", "Fusion" };
                string[] trims = new string[] { "High Country", "R/T", "Awesome" };
                Random rng = new Random();
                List<CodeFirstCar> cars = new List<CodeFirstCar>();
                for (int i = 1; i <= 50; i++)
                {
                    cars.Add(new CodeFirstCar()
                    {
                        ID = i,
                        ManufacturerID = 1,
                        Model = models[rng.Next(0, 3)],
                        TrimLevel = trims[rng.Next(0, 3)],
                        Colour = "Black",
                        Odometer = rng.Next(1000, 300001)
                    });
                }


                // Seed data is used for testing environments, it's kind of the equivalent of what we did with INSERTing test data using SQL.
                entity.HasData(cars.ToArray());
            });

            // Call the partial method in case we add some stuff to another file later.
            OnModelCreatingPartial(modelBuilder);
        }

        // Not technically needed, but the scaffolding generates it for later use, so we can add it if we want for future-proofing.
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}