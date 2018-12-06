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
        public int LTNumber { get; set; }
        public virtual WorkOrders WorkOrders { get; set; }
        public int SampleID { get; set; }
        public int TestTypeID { get; set; }
        public virtual TestCatalog TestCatalog { get; set; }//foreign key
        public int EmployeeID { get; set; }
        public virtual Employees Employees { get; set; }//foreign key
        public int StatusID { get; set; }//foreign key
        public virtual Status Status { get; set; }

    }
}