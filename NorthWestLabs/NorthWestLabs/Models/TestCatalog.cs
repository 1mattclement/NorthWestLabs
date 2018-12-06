using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    [Table("TestCatalog")]
    public class TestCatalog
    {
        [Key]
        public int TestTypeID { get; set; }
        // public int? EmployeeID { get; set; }
        public double TestPrice { get; set; }
        public double MaterialsCost { get; set; }
        public double BasePrice { get; set; }

    }
}