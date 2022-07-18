using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class ExternalUnifiedModel
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
        //public string gpccode { get; set; } - same as brickcategory_id in Product Model
        [StringLength(255)]
        public string atccode { get; set; } // Anatomical Therapeutical Chemical
        [StringLength(255)]
        public string packsize { get; set; }
        [StringLength(255)]
        public string quantity { get; set; } //This is the combination of the netweight and the netcontent_id in the Product Model e.g 500mg * 20 Tablet
        [StringLength(255)]
        public string unitofmeasure { get; set; }
        [StringLength(255)]
        public string primarypackagingmaterial { get; set; } //packaginglevel property in Product model can be the same
        [StringLength(255)]
        public string labeldescription { get; set; }

        public DateTime datecreated { get; set; }
        public string createdby { get; set; }
        public DateTime datemodified { get; set; }
        public string modifiedby { get; set; }


        [ForeignKey(nameof(product_id))]
        public Product Product { get; set; }
    }
}
