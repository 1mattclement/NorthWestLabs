using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    [Table("WorkOrders")]
    public class WorkOrders
    {
        [Key]
        public int WorkOrderID { get; set; }

        public string Comments { get; set; }

        [DisplayName("Rush Order")]
        public bool RushOrder { get; set; }

        [DisplayName("Customer ID")]
        [Required(ErrorMessage = "Please enter your customer ID")]
        public int? CustomerID { get; set; }
        public virtual Customers Customers { get; set; }//add virtual

        /**[DisplayName("Payment Info")]
        [Required(ErrorMessage = "Please enter your payment ID")]
        public int PmtInfoID { get; set; }**/

        [DisplayName("LTNumber")]
        [Required(ErrorMessage = "Please enter your compound LTNumber")]
        public int? LTNumber { get; set; }
        public virtual Compound Compound {get; set;}

    
        

  
    }
}