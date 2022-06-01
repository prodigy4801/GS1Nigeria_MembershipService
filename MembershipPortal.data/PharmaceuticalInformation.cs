using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MembershipPortal.data
{
    public class PharmaceuticalInformation{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string  GenericName { get; set; }
        public string  TradeItemDescription { get; set; }
        public string  Strength { get; set; }
        public string  ProductForm { get; set; }
        public string  RouteOfAdministration { get; set; }
        public string  ATCCode { get; set; }
        public string  PackSize { get; set; }
        public string  Quantity { get; set; }
        public string  PrimaryPackagingMaterial { get; set; }
        public string  Manufacturer { get; set; }
        public string  ManufacturerAddress { get; set; }       
        
        public int ProductID { get; set; }
        public Product Product { get; set; }

    }
}