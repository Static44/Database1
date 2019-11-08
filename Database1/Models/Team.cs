﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Database1.Models
{
    [Table("Team")]
    public class Team
    {
        [Key]
        public String teamID { get; set; }
        public String teamName { get; set; }
    }
}