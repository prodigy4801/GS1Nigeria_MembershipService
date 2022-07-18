using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class ExternalUnifiedModelVM
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public string functionalname { get; set; }
        public string genericname { get; set; }
        public string tradeitemdescription { get; set; }
        public string strength { get; set; }
        public string productform { get; set; }
        public string routeofadministration { get; set; }
        public string shelflife { get; set; }
        //public string gpccode { get; set; } - same as brickcategory_id in Product Model
        public string atccode { get; set; } // Anatomical Therapeutical Chemical
        public string packsize { get; set; }
        public string quantity { get; set; } //This is the combination of the netweight and the netcontent_id in the Product Model e.g 500mg * 20 Tablet
        public string unitofmeasure { get; set; }
        public string primarypackagingmaterial { get; set; } //packaginglevel property in Product model can be the same
        public string labeldescription { get; set; }

        public DateTime datecreated { get; set; }
        public string createdby { get; set; }
        public DateTime datemodified { get; set; }
        public string modifiedby { get; set; }
        public ProductVM Product { get; set; }

        //Other information not found in this model exist in the Product Model.
    }

    public class ExternalUnifiedModelVM_CRU
    {
        public int id { get; set; }
        [Required]
        public int product_id { get; set; }
        [StringLength(255)]
        public string functionalname { get; set; }
        [StringLength(255)]
        public string genericname { get; set; }
        [StringLength(255)]
        public string tradeitemdescription { get; set; }
        [StringLength(255)]
        public string strength { get; set; }
        [StringLength(255)]
        public string productform { get; set; }
        [StringLength(255)]
        public string routeofadministration { get; set; }
        [StringLength(255)]
        public string shelflife { get; set; }
        [StringLength(255)]
        public string atccode { get; set; }
        [StringLength(255)]
        public string packsize { get; set; }
        [StringLength(255)]
        public string quantity { get; set; }
        [StringLength(255)]
        public string unitofmeasure { get; set; }
        [StringLength(255)]
        public string primarypackagingmaterial { get; set; }
        [StringLength(255)]
        public string labeldescription { get; set; }

        public string createdby { get; set; }
        public string modifiedby { get; set; }
    }
}
