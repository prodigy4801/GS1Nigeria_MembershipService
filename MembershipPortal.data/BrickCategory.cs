﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class BrickCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public int brick_id { get; set; }
        public DateTime createddate { get; set; }
        public DateTime modifieddate { get; set; } 
        public string brick { get; set; }
        public List<Product> Products { get; set; }

       
    }
}
