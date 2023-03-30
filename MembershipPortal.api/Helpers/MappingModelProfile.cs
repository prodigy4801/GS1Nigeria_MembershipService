using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MembershipPortal.api.Models;
using MembershipPortal.service;
using MembershipPortal.service.Models;
using MembershipPortal.viewmodels;

namespace MembershipPortal.api.Helpers
{
    public class MappingModelProfile : Profile
    {
        public MappingModelProfile()
        {
            CreateMap(typeof(GenericResponse<>), typeof(ServiceResponse<>)).ReverseMap();
            CreateMap(typeof(GenericResponseList<>), typeof(ServiceResponseList<>)).ReverseMap();
            //CreateMap(typeof(GenericResponseList<>), typeof(ExternalServiceResponseList<>)).ReverseMap();
            CreateMap<ProductImageUpload, ImageUploadModel>().ReverseMap();
        }
    }
}
