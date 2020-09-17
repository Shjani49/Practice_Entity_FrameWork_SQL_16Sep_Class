using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Practice_SQL.Models
{
    // Declares the name of the database table.
    [Table("code_first_car")]
    public partial class CodeFirstCar
    {
        // Declare a primary key.
        [Key]
       
        // Specifies AUTO_INCREMENT.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // Declare the column name and the data type.
        // MySQL data type, NOT C# data type.
        [Column("id", TypeName = "int(10)")]
        // Declare the C# property that will map onto that database column.
        public int ID { get; set; }

        [Column("manufacturer", TypeName = "varchar(30)")]
        // Specifies NOT NULL on nullable types.
        // Ints do not require this to be NOT NULL as they are not nullable.
        // You must make a nullable int (int?) in order to specify NULL.
        [Required]
        public string Manufacturer { get; set; }

        [Column("model", TypeName = "varchar(30)")]
        [Required]
        public string Model { get; set; }

        [Column("trim_level", TypeName = "varchar(30)")]
        [Required]
        public string TrimLevel { get; set; }

        [Column("colour", TypeName = "varchar(10)")]
        [Required]
        public string Colour { get; set; }

        [Column("odometer", TypeName = "int(10)")]
        // To make a NULL int, we can specify the data type as "int?".
        public int Odometer { get; set; }
    }
}
