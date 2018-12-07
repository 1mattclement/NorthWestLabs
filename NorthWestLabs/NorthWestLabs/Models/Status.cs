using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    [Table("Status")]
    public class Status
    {
        [Key]
        [DisplayName("Status ID")]
        public int StatusID { get; set; }

        [DisplayName("Status Description")]
        public string StatusDescription { get; set; }
    }
}