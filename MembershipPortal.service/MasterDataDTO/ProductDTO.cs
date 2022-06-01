using System;

namespace MembershipPortal.service.MasterDataDTO
{
    public class ProductDTO{       
        public string gtin { get; set; }     
        public int? netcontent_id { get; set; }        
        public string brandname { get; set; }
        public int? packagingtype_id { get; set; }        
        public string productdescription { get; set; }        
        public string marketingmessage { get; set; }
        public int? targetmarket_id { get; set; }
        public DateTime consumerfirstavailabilitydate { get; set; }
        public double netweight { get; set; }
        
        public double grossweight { get; set; }
        public int? brickcategory_id { get; set; }        
        public string frontimage { get; set; }
          
        public string backimage { get; set; }  
        public string ingredients { get; set; }           
        public string allergeninfo { get; set; }               
        public string nafdacnumber { get; set; }           
        public string storageinstruction { get; set; }              
        public string directionofuse { get; set; }
        public int lifespan { get; set; }            
        public string lifespanunit { get; set; }
        public int? packaginglevel_id { get; set; }
        
       
    }
}