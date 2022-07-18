using AutoMapper;
using MembershipPortal.data;
using MembershipPortal.viewmodels;
using MembershipPortal.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.configurations
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            CreateMap<BrandInformationVM, BrandInformation>().ReverseMap();
            CreateMap<BrandInformationVM_CRU, BrandInformation>().ReverseMap();

            CreateMap<BrickCategoryVM, BrickCategory>().ReverseMap();
            CreateMap<BrickCategoryVM_CRU, BrickCategory>().ReverseMap();

            CreateMap<ExternalUnifiedModelVM, ExternalUnifiedModel>().ReverseMap();
            CreateMap<ExternalUnifiedModelVM_CRU, ExternalUnifiedModel>().ReverseMap();

            CreateMap<GLNInformationVM, GLNInformation>().ReverseMap();
            CreateMap<GLNInformationVM_CRU, GLNInformation>().ReverseMap();

            CreateMap<GTINInformationVM, GTINInformation>().ReverseMap();
            CreateMap<GTINInformationVM_CRU, GTINInformation>().ReverseMap();

            CreateMap<ITFInformationVM, ITFInformation>().ReverseMap();
            CreateMap<ITFInformationVM_CRU, ITFInformation>().ReverseMap();

            CreateMap<NetContentVM, NetContent>().ReverseMap();
            CreateMap<NetContentVM_CRU, NetContent>().ReverseMap();

            CreateMap<PackageLevelVM, PackageLevel>().ReverseMap();
            CreateMap<PackageLevelVM_CRU, PackageLevel>().ReverseMap();

            CreateMap<PackagingTypeVM, PackagingType>().ReverseMap();
            CreateMap<PackagingTypeVM_CRU, PackagingType>().ReverseMap();

            CreateMap<ProductVM, Product>().ReverseMap();
            CreateMap<ProductVM_CRU, Product>().ReverseMap();

            CreateMap<TargetMarketVM, TargetMarket>().ReverseMap();
            CreateMap<TargetMarketVM_CRU, TargetMarket>().ReverseMap();
        }
    }
}
