using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_SQL.Models
{
    [Table("manufacturer")]
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Cars = new HashSet<Car>();
        }

        [Key]
        [Column("ID", TypeName = "int(10)")]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }

        [InverseProperty("Manufacturer")]
        public virtual ICollection<Car> Cars { get; set; }
    }
}
