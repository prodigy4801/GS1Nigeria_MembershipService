using MembershipPortal.data.ExternalEntries;
using MembershipPortal.data.ExternalEntries.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service.Concrete.ExternalEntries
{
    public interface IImageRequestSvc : IGenericExternalAPICallsSvc<ImageRequestModel>
    {
    }
    public class ImageRequestSvc : GenericExternalAPICallsSvc<ImageRequestModel>, IImageRequestSvc
    {

    }
}
