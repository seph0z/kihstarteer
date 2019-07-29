using System;
using System.Collections.Generic;
using System.Text;
using Profile = AutoMapper.Profile;
using AutoMapper;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseProject.Infrastructure.MappingProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            MapUserToUserViewModel();
            MapUserViewModelToUser();
        }

        private void MapUserToUserViewModel()
        {
            CreateMap<AspNetUsers, UserViewModel>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Image, c => c.MapFrom(src => src.Image))
                .ForMember(dest => dest.Biography, c => c.MapFrom(src => src.Biography))
                .ForMember(dest => dest.Country, c => c.MapFrom(src => src.Country))
                .ForMember(dest => dest.Role, c => c.MapFrom(src => src.AspNetUserRoles.ToList().FirstOrDefault().Role.Name))
                .ForAllOtherMembers(c => c.Ignore());
        }

        private void MapUserViewModelToUser()
        {
            CreateMap<UserViewModel, AspNetUsers>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserName, c => c.MapFrom(src => src.Name))
                .ForMember(dest => dest.Image, c => c.MapFrom(src => src.Image))
                .ForMember(dest => dest.Biography, c => c.MapFrom(src => src.Biography))
                .ForMember(dest => dest.Country, c => c.MapFrom(src => src.Country))
                .ForAllOtherMembers(c => c.Ignore());
        }
    }
}
