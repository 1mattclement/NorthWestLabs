using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    [Table("Compound")]
    public class Compound
    {
        [Key]
        
        public int LTNumber { get; set; }

        public string CompoundName { get; set; }
        public double Quantity { get; set; }
        public DateTime DateArrived { get; set; }
        public int? EmployeeID { get; set; } //Foriegn Key
        public DateTime DateDue { get; set; }
        public string Appearance { get; set; }
        public double Weight { get; set; }
        public double MolecularMass { get; set; }
        public double MTD { get; set; }

    }
}