using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class ImageBankVM
    {
        public int id { get; set; }
        public string registrationid { get; set; }
        public int imageReserve { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime lastModified { get; set; }
    }

    public class ImageBankVM_create
    {

        [Required]
        [StringLength(100)]
        public string registrationid { get; set; }
        public int imageReserve { get; set; }
    }
    public class ImageBankVM_update
    {
        public int id { get; set; }
        public int imageReserve { get; set; }
    }

    public class BarcodeGenerateVM
    {
        public BarcodeFormat formatType { get; set; } // From the BarcodeFormat
        public string gtin { get; set; }
    }

    public enum BarcodeFormat
    {
        PNG,
        EMF,
        WMF,
        PDF

    }
}
