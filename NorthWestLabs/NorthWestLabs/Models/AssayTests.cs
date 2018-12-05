using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    [Table("AssayTests")]
    public class AssayTests
    {
        [Key]
        public int AssayTypeID { get; set; }
        public int TestTypeID { get; set; }
        public bool Required { get; set; }
        public bool Conditional { get; set; }
   
    }
}