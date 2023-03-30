using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class CompanySectorCategory
    {
        public int id { get; set; }
        public string sectorcategory { get; set; }
        public string sectorcode { get; set; }
    }
}
