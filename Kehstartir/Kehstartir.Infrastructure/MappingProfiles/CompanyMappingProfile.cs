using Profile = AutoMapper.Profile;
using System;
using System.Collections.Generic;
using System.Text;
using Kehstartir.Data.Contracts.Entities;
using Kehstartir.Domain.Contracts.ViewModels;
using AutoMapper;

namespace Kehstartir.Infrastructure.MappingProfiles
{
    public class CompanyMappingProfile : Profile
    {
        public CompanyMappingProfile()
        {
            MapCompanyToCompanyViewModel();
            MapCompanyViewModelToCompany();
            MapCompanyTagToString();
            MapStringToCompanyTag();
        }

        private void MapCompanyToCompanyViewModel()
        {
            CreateMap<Company, CompanyViewModel>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, c => c.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, c => c.MapFrom(src => src.Description))
                .ForMember(dest => dest.VideoLink, c => c.MapFrom(src => src.VideoLink))
                .ForMember(dest => dest.Amount, c => c.MapFrom(src => src.Amount))
                .ForMember(dest => dest.ExpirationDate, c => c.MapFrom(src => src.ExpirationDate))
                .ForMember(dest => dest.Theme, c => c.MapFrom(src => src.Theme.Name))
                .ForMember(dest => dest.UserId, c => c.MapFrom(src => src.UserId))
                //.ForMember(dest => dest.UserName, c => c.MapFrom(src => src.User.UserName))
                .ForMember(dest => dest.Tags, c => c.MapFrom(src => src.CompanyTags))
                .ForMember(dest => dest.Rating, c => c.MapFrom(src => src.Rating.Sum))
                .ForAllOtherMembers(c => c.Ignore());

        }

        private void MapCompanyViewModelToCompany()
        {
            CreateMap<CompanyViewModel, Company>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, c => c.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, c => c.MapFrom(src => src.Description))
                .ForMember(dest => dest.VideoLink, c => c.MapFrom(src => src.VideoLink))
                .ForMember(dest => dest.Amount, c => c.MapFrom(src => src.Amount))
                .ForMember(dest => dest.ExpirationDate, c => c.MapFrom(src => src.ExpirationDate))
                .ForPath(dest => dest.Theme.Name, c => c.MapFrom(src => src.Theme))
                .ForMember(dest => dest.UserId, c => c.MapFrom(src => src.UserId))
                //.ForPath(dest => dest.User.UserName, c => c.MapFrom(src => src.UserName))
                .ForPath(dest => dest.CompanyTags, c => c.MapFrom(src => src.Tags))
                .ForPath(dest => dest.Rating.Sum, c => c.MapFrom(src => src.Rating))
                .ForAllOtherMembers(c => c.Ignore());
        }

        public void MapCompanyTagToString()
        {
            CreateMap<CompanyTag, string>()
                .ConvertUsing(new StringCompanyTagConverter());
        }

        public void MapStringToCompanyTag()
        {
            CreateMap<string, CompanyTag>()
                .ConvertUsing(new CompanyTagStringConverter());

        }
    }

    public class CompanyTagStringConverter : ITypeConverter<string, CompanyTag>
    {
        public CompanyTag Convert(string source, CompanyTag destination, ResolutionContext context)
        {
            var companyTag = new CompanyTag { Tag = new Tag { Text = source } };
            return companyTag;
        }
    }

    public class StringCompanyTagConverter : ITypeConverter<CompanyTag, string>
    {
        public string Convert(CompanyTag source, string destination, ResolutionContext context)
        {
            var tag = source.Tag.Text;
            return tag;
        }
    }
}
