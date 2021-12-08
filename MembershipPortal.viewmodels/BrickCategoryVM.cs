﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class BrickCategoryVM
    {
        public int id { get; set; }
        public int brick_id { get; set; }
        public string brick { get; set; }
        public DateTime createddate { get; set; }
        public DateTime? modifieddate { get; set; }
    }

    public class BrickCategoryVM_CRU
    {
        public int id { get; set; }
        [Required]
        public int brick_id { get; set; }
        [StringLength(100)]
        public string brick { get; set; }
    }
}
