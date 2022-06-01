﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationBackend.data.Models
{
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string name { get; set; }
        public int country_id { get; set; }

        [ForeignKey("country_id")]
        public Country Country { get; set; }
        public ICollection<LocalGovt> LocalGovt_State { get; set; }
        //public ICollection<Company> Company_State { get; set; }
    }
}