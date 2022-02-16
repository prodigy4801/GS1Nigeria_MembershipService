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

        public static class RBrickCategory
        {
            public const string GetAll = Base + "/brickcategory";
            public const string Create = Base + "/brickcategory";
            public const string GetByID = Base + "/brickcategory/{id}";
            public const string Delete = Base + "/brickcategory";
            public const string Update = Base + "/brickcategory/{id}";
        }

        public static class RGLNInformation
        {
            public const string GetAll = Base + "/glninformation";
            public const string Create = Base + "/glninformation";
            public const string GetByID = Base + "/glninformation/{id}";
            public const string Delete = Base + "/glninformation";
            public const string Update = Base + "/glninformation/{id}";
        }

        public static class RGTINInformation
        {
            public const string GetAll = Base + "/gtininformation";
            public const string Create = Base + "/gtininformation";
            public const string GetByID = Base + "/gtininformation/{id}";
            public const string Update = Base + "/gtininformation/{id}";
            public const string Delete = Base + "/gtininformation";
        }

        public static class RITFInformation
        {
            public const string GetAll = Base + "/itfinformation";
            public const string Create = Base + "/itfinformation";
            public const string GetByID = Base + "/itfinformation/{id}";
            public const string Update = Base + "/itfinformation/{id}";
            public const string Delete = Base + "/itfinformation";
        }

        public static class RNetContent
        {
            public const string GetAll = Base + "/netcontent";
            public const string Create = Base + "/netcontent";
            public const string GetByID = Base + "/netcontent/{id}";
            public const string Update = Base + "/netcontent/{id}";
            public const string Delete = Base + "/netcontent";
        }

        public static class RPackageLevel
        {
            public const string GetAll = Base + "/packagelevel";
            public const string Create = Base + "/packagelevel";
            public const string GetByID = Base + "/packagelevel/{id}";
            public const string Update = Base + "/packagelevel/{id}";
            public const string Delete = Base + "/packagelevel";
        }

        public static class RPackagingType
        {
            public const string GetAll = Base + "/packagingtype";
            public const string Create = Base + "/packagingtype";
            public const string GetByID = Base + "/packagingtype/{id}";
            public const string Delete = Base + "/packagingtype";
            public const string Update = Base + "/packagingtype/{id}";
        }

        public static class RProduct
        {
            public const string GetAll = Base + "/product";
            public const string Create = Base + "/product";
            public const string UploadCreate = Base + "/product/upload";
            public const string GetByID = Base + "/product/{id}";
            public const string Delete = Base + "/product";
            public const string Update = Base + "/product/{id}";
        }

        public static class RTargetMarket
        {
            public const string GetAll = Base + "/targetmarket";
            public const string Create = Base + "/targetmarket";
            public const string GetByID = Base + "/targetmarket/{id}";
            public const string Delete = Base + "/targetmarket";
            public const string Update = Base + "/targetmarket/{id}";
        }

        public static class RAPIAuthentication
        {
            public const string AuthenticateCredentials = Base + "/authentication/generate-token";
            //public const string Register = Base + "/authentication/register";
            //public const string GetByID = Base + "/authentication/{id}";
            //public const string Delete = Base + "/authentication";
            //public const string Update = Base + "/authentication/{id}";
        }
    }
}
