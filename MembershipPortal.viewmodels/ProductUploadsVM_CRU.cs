using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class ProductUploadsVM_CRU
    {
        public string registrationid { get; set; }
        public List<ProductUpload> ProductUploads { get; set; }
    }

    public class ProductUpload
    {
        public string gtin { get; set; }
        public string netcontent { get; set; }
        public string brandname { get; set; }
        public string packagingtype { get; set; }
        public string productdescription { get; set; }
        public string marketingmessage { get; set; }
        public string targetmarket { get; set; }
        public DateTime availabilitydate { get; set; }
        public double netweight { get; set; }
        public double grossweight { get; set; }
        public string category { get; set; }
        public string ingredients { get; set; }
        public string allergeninformation { get; set; }
        public string nafdacnumber { get; set; }
        public string storageinformation { get; set; }
        public string directionofuse { get; set; }
        public int lifespan { get; set; }
        public string lifespanunit { get; set; }
        public string packaginglevel { get; set; }
    }
}
