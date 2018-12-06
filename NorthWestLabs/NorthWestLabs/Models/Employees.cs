using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    [Table("Employees")]
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }

        [DisplayName("Employee First Name")]
        public string EmpFirstName { get; set; }
        [DisplayName("Employee Last Name")]
        public string EmpLastName { get; set; }
        [DisplayName("Position")]
        public int? PositionID { get; set; }

    }
}