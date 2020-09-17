using Practice_SQL.Models;
using System;
using System.Linq;

namespace Practice_SQL
{
    class Program
    {
        static void Main (string[] args)
        {
            // Using "Code First" techniques allow us to make changes and even create entire databases without writing a single line of SQL.
            /*
            Ensure you have the Microsoft Design and Pomelo MySql packages installed as per the notes on the master branch.
            Throughout this, if you encounter red lines in any file, use Ctrl+. to add the proposed "using" statements.
               
            1) Add new "Models" folder.
            2) Add classes to "Models".
                2a) Add a public partial "ThingContext.cs" class inheriting from DbContext.
                2b) Add public partial column classes.
            3) Set up skeleton context class.
                3a) Create constructors.
                    3a1) Create a empty default constructor.
                    3a2) Create a constructor that acceps a DbContextOptions<ThisContext> options, and calls the base constructor.
                3b) Create configuration methods.
                    3b1) Add an OnConfiguring() override that accepts a DbContextOptionsBuilder, if that option builder's "IsConfigured" property is false, declare the connection string for the database.
                    3b2) Add an OnModelCreating override that accepts a ModelBuilder, call OnModelCreatingPartial() at the end.
                    3b3) Add a partial OnModelCreatingPartial override call at the end with no body.
            4) Set up skeleton column classes.
                4a) Declare table name.
                4b) Declare columns (names and types).
                4c) Declare foreign keys (if applicable).

            */

        }

    }
}
