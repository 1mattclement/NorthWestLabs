using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    [Table("AssayCatalog")]
    public class AssayCatalog
    {
        [Key]
        public int AssayTypeID { get; set; }
        public string ProtocolDescription { get; set; }
        public string LitReference { get; set; }
        public double EstCompletionTime { get; set; }
        public string AssayName { get; set; }

    }
}