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
    public interface IGTINRequestSvc : IGenericRegistrationCallSvc<GTINRequestModel, GTINRequestModel_Create>
    {
    }
    public class GTINRequestSvc : GenericRegistrationCallSvc<GTINRequestModel, GTINRequestModel_Create>, IGTINRequestSvc
    {

    }
}
