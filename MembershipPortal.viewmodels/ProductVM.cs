using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class ProductVM
    {
        public int id { get; set; }
        public string gtin { get; set; }
        public string registrationid { get; set; }
        public int netcontent_id { get; set; }
        public string brandname { get; set; }
        public int packagingtype_id { get; set; }
        public string productdescription { get; set; }
        public string marketingmessage { get; set; }
        public int targetmarket_id { get; set; }
        public DateTime consumerfirstavailabilitydate { get; set; }
        public double netweight { get; set; }
        public bool iscompleted { get; set; }
        public double grossweight { get; set; }
        public int brickcategory_id { get; set; }
        public string frontimage { get; set; }
        public bool hasimage { get; set; }
        public string backimage { get; set; }
        public DateTime dateoflisting { get; set; }
        public string ingredients { get; set; }
        public string allergeninfo { get; set; }
        public string nafdacnumber { get; set; }
        public string storageinstruction { get; set; }
        public string directionofuse { get; set; }
        public int lifespan { get; set; }
        public string lifespanunit { get; set; }
        public int packaginglevel_id { get; set; }
        public DateTime createddate { get; set; }
        public DateTime modifieddate { get; set; }

        public BrickCategoryVM BrickCategory { get; set; }
        public NetContentVM NetContent { get; set; }
        public PackagingTypeVM PackagingType { get; set; }
        public PackageLevelVM PackageLevel { get; set; }
        public TargetMarketVM TargetMarket { get; set; }
    }

    public class ProductVM_CRU
    {
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string gtin { get; set; }
        [Required]
        [StringLength(100)]
        public string registrationid { get; set; }
        public int netcontent_id { get; set; }
        [Required]
        [StringLength(200)]
        public string brandname { get; set; }
        public int packagingtype_id { get; set; }
        [StringLength(200)]
        public string productdescription { get; set; }
        [StringLength(500)]
        public string marketingmessage { get; set; }
        public int targetmarket_id { get; set; }
        public DateTime consumerfirstavailabilitydate { get; set; }
        public double netweight { get; set; }
        public bool iscompleted { get; set; }
        public double grossweight { get; set; }
        public int brickcategory_id { get; set; }
        [StringLength(200)]
        public string frontimage { get; set; }
        public bool hasimage { get; set; }
        [StringLength(200)]
        public string backimage { get; set; }
        public DateTime dateoflisting { get; set; }
        [StringLength(500)]
        public string ingredients { get; set; }
        [StringLength(500)]
        public string allergeninfo { get; set; }
        [StringLength(100)]
        public string nafdacnumber { get; set; }
        [StringLength(500)]
        public string storageinstruction { get; set; }
        [StringLength(500)]
        public string directionofuse { get; set; }
        public int lifespan { get; set; }
        [StringLength(500)]
        public string lifespanunit { get; set; }
        public int packaginglevel_id { get; set; }
    }
}
