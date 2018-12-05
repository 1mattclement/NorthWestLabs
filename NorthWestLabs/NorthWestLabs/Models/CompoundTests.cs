using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    [Table("CompoundTests")]
    public class CompoundTests
    {
        [Key]
        public int TestID { get; set; }
        public int LTNumber { get; set; } //foreign key
        public int SampleID { get; set; }
        public int TestTypeID { get; set; }//foreign key
        public int EmployeeID { get; set; }//foreign key
        public int StatusID { get; set; }//foreign key

    }
}