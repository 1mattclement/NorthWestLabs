using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("LT Number")]
        public int LTNumber { get; set; }

        [DisplayName("Compound Number")]
        public string CompoundName { get; set; }


        public double Quantity { get; set; }

        [DisplayName("Date Arrived")]
        public DateTime DateArrived { get; set; }
        //public int? EmployeeID { get; set; } 
        // public virtual Employees Employees { get; set; }
        //Foriegn Key
        [DisplayName("Date Due")]
        public DateTime DateDue { get; set; }
        public string Appearance { get; set; }
        public double Weight { get; set; }

        [DisplayName("Molecular Mass")]
        public double MolecularMass { get; set; }
        public double MTD { get; set; }

    }
}