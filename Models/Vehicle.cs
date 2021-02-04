using BaseProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Models
{
    public class Vehicle : IEntity
    {
        [Key]
        [Column("Vehicle_Id")]
        public Guid Id { get; set; }

        [Range(1000,9999)]
        [Required]
        public int Year { get; set; } = 0;

        [Required]
        [MinLength(4)]
        public string Make { get; set; } = string.Empty;

        [Required]
        [MinLength(4)]
        public string Model { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal MSRP { get; set; } = 0;
    }
}
