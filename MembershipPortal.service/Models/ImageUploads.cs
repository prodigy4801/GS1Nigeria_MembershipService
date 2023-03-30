using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service.Models
{
    public class ImageUploadModel
    {
        public IFormFile? FrontImage { get; set; }
        public IFormFile? BackImage { get; set; }
        public IFormFile? LeftImage { get; set; }
        public IFormFile? RightImage { get; set; }
        public IFormFile? OtherImage { get; set; }
    }

    public class ImagePathModel
    {
        public string Front { get; set; }
        public string Back { get; set; }
        public string Left { get; set; }
        public string Right { get; set; }
        public string Other { get; set; }
    }
}
