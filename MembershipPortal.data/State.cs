﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class State
    {
        public int id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }

        [ForeignKey("country_id")]
        public Country Country { get; set; }
    }
}
