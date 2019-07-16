using Profile = AutoMapper.Profile;
using System;
using System.Collections.Generic;
using System.Text;
using Kehstartir.Data.Contracts.Entities;
using Kehstartir.Domain.Contracts.ViewModels;
using AutoMapper;

namespace Kehstartir.Infrastructure.MappingProfiles
{
    public class CampaignMappingProfile : Profile
    {
        public CampaignMappingProfile()
        {
            MapCompanyToCompanyViewModel();
            MapCompanyViewModelToCompany();
            MapCompanyTagToString();
            MapStringToCompanyTag();
        }

        private void MapCompanyToCompanyViewModel()
        {
            CreateMap<Campaign, CampaignViewModel>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, c => c.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, c => c.MapFrom(src => src.Description))
                .ForMember(dest => dest.Content, c => c.MapFrom(src => src.Content))
                .ForMember(dest => dest.VideoLink, c => c.MapFrom(src => src.VideoLink))
                .ForMember(dest => dest.Amount, c => c.MapFrom(src => src.Amount))
                .ForMember(dest => dest.ExpirationDate, c => c.MapFrom(src => src.ExpirationDate))
                .ForMember(dest => dest.Theme, c => c.MapFrom(src => src.Theme.Name))
                .ForMember(dest => dest.UserId, c => c.MapFrom(src => src.UserId))
                //.ForMember(dest => dest.UserName, c => c.MapFrom(src => src.User.UserName))
                .ForMember(dest => dest.Tags, c => c.MapFrom(src => src.CampaignTags))
                .ForMember(dest => dest.Rating, c => c.MapFrom(src => src.Rating.Sum))
                .ForAllOtherMembers(c => c.Ignore());

        }

        private void MapCompanyViewModelToCompany()
        {
            CreateMap<CampaignViewModel, Campaign>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, c => c.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, c => c.MapFrom(src => src.Description))
                .ForMember(dest => dest.Content, c => c.MapFrom(src => src.Content))
                .ForMember(dest => dest.VideoLink, c => c.MapFrom(src => src.VideoLink))
                .ForMember(dest => dest.Amount, c => c.MapFrom(src => src.Amount))
                .ForMember(dest => dest.ExpirationDate, c => c.MapFrom(src => src.ExpirationDate))
                .ForPath(dest => dest.Theme.Name, c => c.MapFrom(src => src.Theme))
                .ForMember(dest => dest.UserId, c => c.MapFrom(src => src.UserId))
                //.ForPath(dest => dest.User.UserName, c => c.MapFrom(src => src.UserName))
                .ForPath(dest => dest.CampaignTags, c => c.MapFrom(src => src.Tags))
                .ForPath(dest => dest.Rating.Sum, c => c.MapFrom(src => src.Rating))
                .ForAllOtherMembers(c => c.Ignore());
        }

        public void MapCompanyTagToString()
        {
            CreateMap<CampaignTag, string>()
                .ConvertUsing(new StringCampaignTagConverter());
        }

        public void MapStringToCompanyTag()
        {
            CreateMap<string, CampaignTag>()
                .ConvertUsing(new CampaignTagStringConverter());

        }
    }
    public class CampaignTagStringConverter : ITypeConverter<string, CampaignTag>
    {
        public CampaignTag Convert(string source, CampaignTag destination, ResolutionContext context)
        {
            var companyTag = new CampaignTag { Tag = new Tag { Text = source } };
            return companyTag;
        }
    }

    public class StringCampaignTagConverter : ITypeConverter<CampaignTag, string>
    {
        public string Convert(CampaignTag source, string destination, ResolutionContext context)
        {
            var tag = source.Tag.Text;
            return tag;
        }
    }
}
