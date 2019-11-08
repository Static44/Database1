using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Database1.Models
{
    [Table("Position")]
    public class Position
    {
        [Key]
        public String positionCode { get; set; }
        public String positionDesc { get; set; }
    }
}