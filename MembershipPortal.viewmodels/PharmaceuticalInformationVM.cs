using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class PharmaceuticalInformationVM
    {
        public int ID { get; set; }
        public string GenericName { get; set; }
        public string FunctionalName { get; set; }
        public string TradeItemDescription { get; set; }
        public string Strength { get; set; }
        public string ShelfLife { get; set; }
        public string ProductForm { get; set; }
        public string RouteOfAdministration { get; set; }
        public string ATCCode { get; set; }
        public string PackSize { get; set; }
        public string Quantity { get; set; }
        public string ActiveIngredient { get; set; }
        public string PrimaryPackagingMaterial { get; set; }
        public string DirectionOfUse { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerAddress { get; set; }
        //public string GenericName { get; set; }
        //public string TradeItemDescription { get; set; }
        //public string Strength { get; set; }
        //public string ProductForm { get; set; }
        //public string RouteOfAdministration { get; set; }
        //public string ATCCode { get; set; }
        //public string PackSize { get; set; }
        //public string Quantity { get; set; }
        //public string PrimaryPackagingMaterial { get; set; }
        //public string Manufacturer { get; set; }
        //public string ManufacturerAddress { get; set; }

        public int ProductID { get; set; }
        //public ProductVM Product { get; set; }
    }

    public class PharmaceuticalInformationVM_Create
    {
        [StringLength(255)]
        public string GenericName { get; set; }
        public string FunctionalName { get; set; }
        [StringLength(255)]
        public string TradeItemDescription { get; set; }
        public string Strength { get; set; }
        public string ShelfLife { get; set; }
        public string ProductForm { get; set; }
        public string RouteOfAdministration { get; set; }
        public string ATCCode { get; set; }
        public string PackSize { get; set; }
        public string Quantity { get; set; }
        public string ActiveIngredient { get; set; }
        public string PrimaryPackagingMaterial { get; set; }
        public string DirectionOfUse { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerAddress { get; set; }

    }

    public class PharmaceuticalInformationVM_Update
    {
        [StringLength(255)]
        public string GenericName { get; set; }
        public string FunctionalName { get; set; }
        [StringLength(255)]
        public string TradeItemDescription { get; set; }
        public string Strength { get; set; }
        public string ShelfLife { get; set; }
        public string ProductForm { get; set; }
        public string RouteOfAdministration { get; set; }
        public string ATCCode { get; set; }
        public string PackSize { get; set; }
        public string Quantity { get; set; }
        public string ActiveIngredient { get; set; }
        public string PrimaryPackagingMaterial { get; set; }
        public string DirectionOfUse { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerAddress { get; set; }

    }
}
