using AutoMapper;
using Profile = AutoMapper.Profile;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseProject.Infrastructure.MappingProfiles
{
    public class ProfileMappingProfile : Profile
    {
        public ProfileMappingProfile()
        {
            MapProfileToProfileViewModel();
            MapProfileViewModelToProfile();
        }

        private void MapProfileToProfileViewModel()
        {
            CreateMap<CourseProject.Data.Contracts.Entities.Profile, ProfileViewModel>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Image, c => c.MapFrom(src => src.Image))
                .ForMember(dest => dest.UserId, c => c.MapFrom(src => src.UserId))
                .ForAllOtherMembers(c => c.Ignore());
        }

        private void MapProfileViewModelToProfile()
        {
            CreateMap<ProfileViewModel, CourseProject.Data.Contracts.Entities.Profile>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Image, c => c.MapFrom(src => src.Image))
                .ForMember(dest => dest.UserId, c => c.MapFrom(src => src.UserId))
                .ForAllOtherMembers(c => c.Ignore());
        }
    }
}
