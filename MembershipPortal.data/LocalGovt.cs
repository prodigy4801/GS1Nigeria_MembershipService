using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class LocalGovt
    {
        public int id { get; set; }
        public string name { get; set; }
        public int state_id { get; set; }

        [ForeignKey(nameof(state_id))]
        public State States { get; set; }
    }
}
