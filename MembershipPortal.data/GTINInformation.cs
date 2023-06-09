﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class GTINInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string registrationid { get; set; }
        [Required]
        [StringLength(50)]
        public string gtin { get; set; }
        [StringLength(50)]
        public string companyprefix { get; set; }
        [StringLength(50)]
        public string productcode { get; set; }
        public string checksum { get; set; }
        public DateTime createddate { get; set; }
        public DateTime? modifieddate { get; set; }
    }
}
