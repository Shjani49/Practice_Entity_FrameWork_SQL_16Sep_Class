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
                optionsBuilder.UseMySql("CONNECTION_STRING_HERE", x => x.ServerVersion("DB_SERVER_VERSION_HERE"));
            }
        }

        // Called when we're doing database migrations, etc.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // We will add model-related stuff here in the future.


            // Call the partial method in case we add some stuff to another file later.
            OnModelCreatingPartial(modelBuilder);
        }

        // Not technically needed, but the scaffolding generates it for later use, so we can add it if we want for future-proofing.
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
      
}
