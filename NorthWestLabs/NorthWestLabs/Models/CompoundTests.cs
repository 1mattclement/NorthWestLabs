using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWestLabs.Models
{
    [Table("CompoundTests")]
    public class CompoundTests
    {
        [Key]
        public int TestID { get; set; }

        [DisplayName("LT Number")]
        public int LTNumber { get; set; }
        public virtual WorkOrders WorkOrders { get; set; }

        [DisplayName("Sample ID")]
        public int SampleID { get; set; }
        public int TestTypeID { get; set; }
        public virtual TestCatalog TestCatalog { get; set; }//foreign key

        [DisplayName("Employee ID")]
        public int EmployeeID { get; set; }
        public virtual Employees Employees { get; set; }//foreign key

        [DisplayName("Status ID")]
        public int? StatusID { get; set; }//foreign key
        public virtual Status Status { get; set; }

        [DisplayName("Work Order ID")]
        public int? WorkOrderID { get; set; }

    }
}