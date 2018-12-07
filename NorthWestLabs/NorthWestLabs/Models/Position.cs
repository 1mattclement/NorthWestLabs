using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Position ID")]
        public int PositionID { get; set; }

        [DisplayName("Position Description")]
        public string PositionDescription { get; set; }
    }
}