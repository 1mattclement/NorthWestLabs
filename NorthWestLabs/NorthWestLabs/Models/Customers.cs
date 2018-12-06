using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    [Table("Customers")] // this is a test
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter your first name!")]
        public string CustFirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter your last name!")]
        public string CustLastName { get; set; }

        [DisplayName("Customer Address")]
        [Required(ErrorMessage = "Please enter your address!")]
        public string CustAddress { get; set; }

        [DisplayName("Customer State")]
        [Required(ErrorMessage = "Please enter your city!")]
        public string CustState { get; set; }

        [DisplayName("Customer Zip")]
        [Required(ErrorMessage = "Please enter your zipcode")]
        public int CustZIP { get; set; }

        [DisplayName("Customer Phone")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Required(ErrorMessage = "Please enter your phone number!")]
        public string CustPhone { get; set; }

        [DisplayName("Customer Email")]
        [EmailAddress]
        [Required(ErrorMessage = "Please enter your email address!")]
        public string CustEmail { get; set; }

        public int? EmployeeID { get; set; } 
        public virtual Employees Employees {get; set;}
       
        public string Comments { get; set; }

        //public int? DiscountID { get; set; }
      




    }
}