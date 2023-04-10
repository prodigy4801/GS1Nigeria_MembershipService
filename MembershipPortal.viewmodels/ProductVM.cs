using Microsoft.AspNetCore.Http;
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
        public int? brandinformation_id { get; set; }
        public int packagingtype_id { get; set; }
        public string productdescription { get; set; }
        public string marketingmessage { get; set; }
        //public int targetmarket_id { get; set; }
        public DateTime consumerfirstavailabilitydate { get; set; }
        public double netweight { get; set; }
        public bool iscompleted { get; set; }
        public double grossweight { get; set; }
        public int brickcategory_id { get; set; }
        public string frontimage { get; set; }
        public bool hasimage { get; set; }
        public string backimage { get; set; }
        public string leftimage { get; set; }
        [StringLength(500)]
        public string rightimage { get; set; }
        [StringLength(500)]
        public string otherimage { get; set; }
        public DateTime dateoflisting { get; set; }
        public string ingredients { get; set; }
        public string allergeninfo { get; set; }
        public string nafdacnumber { get; set; }
        public string storageinstruction { get; set; }
        public string directionofuse { get; set; }
        public int lifespan { get; set; }
        public string lifespanunit { get; set; }
        public bool IsPharma { get; set; }
        public List<string> TargetMarketList { get; set; } = new List<string>();
        public int packaginglevel_id { get; set; }
        public DateTime createddate { get; set; }
        public DateTime modifieddate { get; set; }

        public BrickCategoryVM BrickCategory { get; set; }
        public NetContentVM NetContent { get; set; }
        public PackagingTypeVM PackagingType { get; set; }
        public PackageLevelVM PackageLevel { get; set; }
        public BrandInformationVM BrandInformation { get; set; }
        public PharmaceuticalInformationVM PharmaceuticalInformation { get; set; }
    }

    public class ProductVM_Create
    {
        public int? netcontent_id { get; set; }
        [Required]
        public int brandinformation_id { get; set; }
        [Required]
        public int packagingtype_id { get; set; }
        [Required]
        [StringLength(200)]
        public string productdescription { get; set; }
        [StringLength(500)]
        public string marketingmessage { get; set; }
        public DateTime consumerfirstavailabilitydate { get; set; }
        [Required]
        public double netweight { get; set; }
        public double? grossweight { get; set; }
        public int brickcategory_id { get; set; }
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
        [Required]
        public int packaginglevel_id { get; set; }
        public bool IsPharma { get; set; } = false;
    }

    public class ProductVM_Update
    {
        public int? netcontent_id { get; set; }
        [Required]
        public int packagingtype_id { get; set; }
        //[Required]
        //[StringLength(255)]
        //public string productdescription { get; set; }
        [StringLength(500)]
        public string marketingmessage { get; set; }
        public DateTime consumerfirstavailabilitydate { get; set; }
        [Required]
        public double netweight { get; set; }
        public double grossweight { get; set; }
        public int brickcategory_id { get; set; }
        [StringLength(500)]
        public string ingredients { get; set; }
        [StringLength(500)]
        public string allergeninfo { get; set; }
        [StringLength(500)]
        public string storageinstruction { get; set; }
        [StringLength(500)]
        public string directionofuse { get; set; }
        public int lifespan { get; set; }
        [StringLength(500)]
        public string lifespanunit { get; set; }
        [Required]
        public int packaginglevel_id { get; set; }

    }

    public class ProductImageUpload
    {
        public IFormFile? FrontImage { get; set; }
        public IFormFile? BackImage { get; set; }
        public IFormFile? LeftImage { get; set; }
        public IFormFile? RightImage { get; set; }
        public IFormFile? OtherImage { get; set; }
    }

    public class ProductVM_CreateWithUploads
    {
        public ProductVM_Create Product { get; set; }
        [Required]
        public List<string> TargetMarketList { get; set; }
        public ProductImageUpload ProductImageUpload { get; set; }
#nullable enable
        public PharmaceuticalInformationVM_Create? PharmaceuticalInformation { get; set; } = null;
    }

    public class ProductVM_UpdateWithUploads
    {
#nullable disable
        [Required]
        public int productID { get; set; }

        [Required]
        public string registrationid { get; set; } = string.Empty;
        public ProductVM_Update Product { get; set; } = new ProductVM_Update();
        [Required]
        public List<string> TargetMarketList { get; set; }
        public ProductImageUpload ProductImageUpload { get; set; } = new ProductImageUpload();
        public PharmaceuticalInformationVM_Update PharmaProduct { get; set; } = new PharmaceuticalInformationVM_Update();
    }

    public class BulkProductWithGTIN_CR
    {
        [Required]
        public string registrationid { get; set; }
        public List<ProductUpload> ProductUploads { get; set; }
    }

    public class BulkProductWithoutGTIN_CR
    {
        [Required]
        public string registrationid { get; set; }
        public List<ProductWithoutGTIN> ProductUploads { get; set; }
    }

    public class ProductUploads
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




        //public int? netcontent_id { get; set; }
        //[Required]
        //public int brandinformation_id { get; set; }
        //[Required]
        //public int packagingtype_id { get; set; }
        //[Required]
        //[StringLength(200)]
        //public string productdescription { get; set; }
        //[StringLength(500)]
        //public string marketingmessage { get; set; }
        //public DateTime consumerfirstavailabilitydate { get; set; }
        //[Required]
        //public double netweight { get; set; }
        //public double? grossweight { get; set; }
        //public int brickcategory_id { get; set; }
        //[StringLength(500)]
        //public string ingredients { get; set; }
        //[StringLength(500)]
        //public string allergeninfo { get; set; }
        //[StringLength(100)]
        //public string nafdacnumber { get; set; }
        //[StringLength(500)]
        //public string storageinstruction { get; set; }
        //[StringLength(500)]
        //public string directionofuse { get; set; }
        //public int lifespan { get; set; }
        //[StringLength(500)]
        //public string lifespanunit { get; set; }
        //[Required]
        //public int packaginglevel_id { get; set; }
    }

}
