using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class ProductUploadsVM_CRU
    {
        [Required]
        public string registrationid { get; set; }
        public List<ProductUpload> ProductUploads { get; set; }
    }

    public class ProductUpload
    {
        [Required]
        [StringLength(13, MinimumLength = 12, ErrorMessage = "Invalid GTIN.")]
        public string gtin { get; set; }
        [Required]
        public string netcontent { get; set; }
        [Required]
        public string brandname { get; set; }
        [Required]
        public string packagingtype { get; set; }
        [Required]
        public string productdescription { get; set; }
        public string marketingmessage { get; set; }
        [Required]
        public string targetmarket { get; set; }
        public DateTime availabilitydate { get; set; }
        [Required]
        public double netweight { get; set; }
        [Required]
        public double grossweight { get; set; }
        [Required]
        public string category { get; set; }
        public string ingredients { get; set; }
        public string allergeninformation { get; set; }
        public string nafdacnumber { get; set; }
        public string storageinformation { get; set; }
        public string directionofuse { get; set; }
        [Required]
        public int lifespan { get; set; }
        [Required]
        public string lifespanunit { get; set; }
        [Required]
        public string packaginglevel { get; set; }
    }

    public class ProductWithoutGTIN
    {
        [Required]
        public string netcontent { get; set; }
        [Required]
        public string brandname { get; set; }
        [Required]
        public string packagingtype { get; set; }
        [Required]
        public string productdescription { get; set; }
        public string marketingmessage { get; set; }
        [Required]
        public string targetmarket { get; set; }
        public DateTime availabilitydate { get; set; }
        [Required]
        public double netweight { get; set; }
        [Required]
        public double grossweight { get; set; }
        [Required]
        public string category { get; set; }
        public string ingredients { get; set; }
        public string allergeninformation { get; set; }
        public string nafdacnumber { get; set; }
        public string storageinformation { get; set; }
        public string directionofuse { get; set; }
        [Required]
        public int lifespan { get; set; }
        [Required]
        public string lifespanunit { get; set; }
        [Required]
        public string packaginglevel { get; set; }
    }
}
