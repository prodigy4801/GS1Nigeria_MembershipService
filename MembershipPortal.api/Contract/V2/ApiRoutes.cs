using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Contract.V2
{
    public class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v2";
        public const string Base = Root + "/" + Version;

        public static class RDashboard
        {
            public const string Get = Base + "/dashboard/{registrationid}";
        }

        public static class RBrandInformation
        {
            public const string GetAll = Base + "/brandinformation/datatable";
            public const string GetActive = Base + "/brandinformation/activebrands";
            public const string GetByID = Base + "/brandinformation/{id}";
            public const string GetByRegID = Base + "/brandinformation/getbyregistrationid/{registrationid}";
            public const string Create = Base + "/brandinformation/createbrandinformation";
            public const string Update = Base + "/brandinformation/updatebrandinformation";
            public const string ChangeStatus = Base + "/brandinformation/changestatus";
        }

        public static class RBrickCategory
        {
            public const string GetAll = Base + "/brickcategory";
            public const string GetByID = Base + "/brickcategory/{id}";
            public const string Create = Base + "/brickcategory/createbrickcategory";
        }

        public static class RExternalUnifiedModel
        {
            public const string GetAll = Base + "/externalunifiedmodel/datatable";
            public const string GetByID = Base + "/externalunifiedmodel/{id}";
            public const string GetByProductID = Base + "/externalunifiedmodel/getbyproductid/{productid}";
            public const string Create = Base + "/externalunifiedmodel/create";
            public const string Update = Base + "/externalunifiedmodel/update";
        }

        public static class RGCPInformation
        {
            public const string GetAll = Base + "/gcpinformation";
            public const string GetByID = Base + "/gcpinformation/getbyid/{id}";
            public const string GetByRegistrationID = Base + "/gcpinformation/getbyregistrationid/{registrationid}";
            public const string Create = Base + "/gcpinformation/create";
            public const string Update = Base + "/gcpinformation/update";
            public const string ChangeActiveStatus = Base + "/gcpinformation/changeactivationstatus";
        }

        public static class RGLNInformation
        {
            public const string GetAll = Base + "/glninformation";
            public const string GetByID = Base + "/glninformation/getbyid/{id}";
            public const string GetByRegistrationID = Base + "/glninformation/getbyregistrationid/{registrationid}";
            public const string Create = Base + "/glninformation/create";
            public const string Update = Base + "/glninformation/update";
        }

        public static class RGTINFee
        {
            public const string GetAll = Base + "/gtinfee";
            public const string Create = Base + "/gtinfee";
            public const string GetByID = Base + "/gtinfee/{id}";
            public const string Update = Base + "/gtinfee/{id}";
        }

        public static class RGTINInformation
        {
            public const string GetAll = Base + "/gtininformation";
            public const string GetByID = Base + "/gtininformation/getbyid/{id}";
            public const string GetByRegistrationID = Base + "/gtininformation/getbyregistrationid/{registrationid}";
            public const string Create = Base + "/gtininformation/create";
            public const string Update = Base + "/gtininformation/update";
        }

        public static class RImageBank
        {
            public const string GetAll = Base + "/imagebank";
            public const string GetByID = Base + "/imagebank/getbyid/{id}";
            public const string GetByRegistrationID = Base + "/imagebank/getbyregistrationid/{registrationid}";
            public const string Create = Base + "/imagebank/create";
            public const string Update = Base + "/imagebank/update";
            public const string GenerateBarcode = Base + "/imagebank/generatebarcode";
            public const string DownloadBarcode = Base + "/imagebank/downloadbarcode";
        }

        public static class RImageRequest
        {
            public const string GetAll = Base + "/imagerequest";
            public const string GetByID = Base + "/imagerequest/getbyid/{id}";
            public const string GetByRegistrationID = Base + "/imagerequest/getbyregistrationid/{registrationid}";
            public const string CreateImageGTIN = Base + "/imagerequest/gtin/create";
            public const string Update = Base + "/imagerequest/update";
        }

        public static class RITFInformation
        {
            public const string GetAll = Base + "/itfinformation";
            public const string GetByID = Base + "/itfinformation/getbyid/{id}";
            public const string GetByRegistrationID = Base + "/itfinformation/getbyregistrationid/{registrationid}";
            public const string Create = Base + "/itfinformation/create";
            public const string Update = Base + "/itfinformation/update";
        }

        public static class RNetContent
        {
            public const string GetAll = Base + "/netcontent";
            public const string GetByID = Base + "/netcontent/getbyid/{id}";
            public const string Create = Base + "/netcontent/create";
        }

        public static class RPackageLevel
        {
            public const string GetAll = Base + "/packagelevel";
            public const string GetByID = Base + "/packagelevel/getbyid/{id}";
            public const string Create = Base + "/packagelevel/create";
        }

        public static class RPackagingType
        {
            public const string GetAll = Base + "/packagingtype";
            public const string GetByID = Base + "/packagingtype/getbyid/{id}";
            public const string Create = Base + "/packagingtype/create";
        }

        public static class RProduct
        {
            public const string GetAll = Base + "/product";
            public const string GetAllDataTable = Base + "/product/datatable";
            public const string GetByRegistrationID = Base + "/product/getbyregistrationid/{registrationid}";
            public const string Create = Base + "/product/create";
            public const string UploadWithGTIN = Base + "/product/uploadwithgtin";
            public const string UploadWithoutGTIN = Base + "/product/uploadwithoutgtin";
            public const string GetByID = Base + "/product/{id}";
            public const string Delete = Base + "/product";
            public const string Update = Base + "/product/updatewithimage";
        }

        public static class RProductTargetMarket
        {
            public const string GetAll = Base + "/producttargetmarket";
            public const string GetByID = Base + "/producttargetmarket/{id}";
            public const string GetByRegistrationID = Base + "/producttargetmarket/getbyregistrationid/{registrationid}";
            public const string Create = Base + "/producttargetmarket/create";
            public const string GetByKey = Base + "/producttargetmarket/getbyKey";
        }

        public static class RTargetMarket
        {
            public const string GetAll = Base + "/targetmarket";
            public const string GetByID = Base + "/targetmarket/getbyid/{id}";
            public const string Create = Base + "/targetmarket/create";
        }

        public static class RAPIAuthentication
        {
            public const string AuthenticateCredentials = Base + "/authentication/generate-token";
            public const string MemberLogin = Base + "/authentication/memberlogin";
            public const string MemberRegistration = Base + "/authentication/memberregistration";
            public const string MemberPasswordChange = Base + "/authentication/passwordchange";
            public const string MemberForgotPassword = Base + "/authentication/forgotpassword";
            //public const string Delete = Base + "/authentication";
            //public const string Update = Base + "/authentication/{id}";
        }
    }

    public class ExternalApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v2";
        public const string Base = Root + "/" + Version;

        public static class RCompany
        {
            public const string GetByRegistrationID = Base + "/company/getbyregid/{registrationid}";
        }

        public static class RGTINRequest
        {
            public const string AdditionalRequest = Base + "/gtinrequest/additional";
        }
    }
}
