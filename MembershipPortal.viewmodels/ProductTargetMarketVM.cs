using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class ProductTargetMarketVM
    {
        public int id { get; set; }
        public int? product_id { get; set; }
        public int targetmarket_id { get; set; }
        public string registrationid { get; set; }
        public DateTime datecreated { get; set; }
        public ProductVM Product { get; set; }
        public TargetMarketVM TargetMarket { get; set; }
    }

    public class ProductTargetMarketVM_Create
    {
        public int product_id { get; set; }
        public int targetmarket_id { get; set; }
        public string registrationid { get; set; }
    }

    public class ProductTargetMarketVM_Update
    {
        public int id { get; set; }
        public int targetmarket_id { get; set; }
    }

    public class ProductTargetMarketVM_Key
    {
        public int product_id { get; set; }
        public string registrationid { get; set; }
    }
}
