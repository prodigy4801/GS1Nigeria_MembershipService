using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class ProductTargetMarket
    {
        public int id { get; set; }
        public int? product_id { get; set; }
        public int targetmarket_id { get; set; }
        public string registrationid { get; set; }
        public DateTime datecreated { get; set; }

        [ForeignKey(nameof(product_id))]
        public Product Product { get; set; }
        [ForeignKey(nameof(targetmarket_id))]
        public TargetMarket TargetMarket { get; set; }
    }
}
