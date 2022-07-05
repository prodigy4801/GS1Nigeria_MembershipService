using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string gtin { get; set; }
        [Required]
        [StringLength(100)]
        public string registrationid { get; set; }
        public int? netcontent_id { get; set; }
        [Required]
        [StringLength(200)]
        public string brandname { get; set; }
        public int? brandinformation_id { get; set; }
        public int? packagingtype_id { get; set; }
        // [StringLength(200)]
        public string productdescription { get; set; }
        // [StringLength(500)]
        public string marketingmessage { get; set; }
        public int? targetmarket_id { get; set; }
        public DateTime consumerfirstavailabilitydate { get; set; }
        public double netweight { get; set; }
        public bool iscompleted { get; set; }
        public double grossweight { get; set; }
        public int? brickcategory_id { get; set; }
        [StringLength(500)]
        public string frontimage { get; set; }
        public bool hasimage { get; set; }
        [StringLength(500)]
        public string backimage { get; set; }
        public DateTime dateoflisting { get; set; }
        // [StringLength(500)]
        public string ingredients { get; set; }
        [StringLength(500)]
        public string allergeninfo { get; set; }
        [StringLength(100)]
        public string nafdacnumber { get; set; }
        // [StringLength(500)]
        public string storageinstruction { get; set; }
        // [StringLength(500)]
        public string directionofuse { get; set; }
        public int lifespan { get; set; }
        [StringLength(500)]
        public string lifespanunit { get; set; }
        public int? packaginglevel_id { get; set; }
        public DateTime createddate { get; set; }
        public DateTime modifieddate { get; set; }

        [ForeignKey(nameof(brickcategory_id))]
        public BrickCategory BrickCategory { get; set; }

        [ForeignKey(nameof(brandinformation_id))]
        public BrandInformation BrandInformation { get; set; }

        [ForeignKey(nameof(netcontent_id))]
        public NetContent NetContent { get; set; }

        [ForeignKey(nameof(packagingtype_id))]
        public PackagingType PackagingType { get; set; }

        [ForeignKey(nameof(packaginglevel_id))]
        public PackageLevel PackageLevel { get; set; }

        [ForeignKey(nameof(targetmarket_id))]
        public TargetMarket TargetMarket { get; set; }
        public bool IsPharma { get; set; }
        public PharmaceuticalInformation PharmaceuticalInformation { get; set; }
    }
}
