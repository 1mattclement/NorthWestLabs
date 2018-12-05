using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestLabs.Models
{
    [Table("Position")]
    public class Position
    {
        [Key]
        public int PositionID { get; set; }
        public string PositionDescription { get; set; }
    }
}