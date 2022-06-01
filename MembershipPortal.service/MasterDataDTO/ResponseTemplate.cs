using System.Collections.Generic;
namespace MembershipPortal.service.MasterDataDTO
{
    public class ReturnSignature<T>
    {
        public ReturnSignature()
        {
            BadData = new List<string>();
            Message = new List<string>();
        }
        public int Status { get; set; }
        public List<string> Message { get; set; }
        public List<string> BadData { get; set; }
        public T ReturnedObject { get; set; }
    }
}
