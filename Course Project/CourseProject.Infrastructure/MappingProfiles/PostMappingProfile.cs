using AutoMapper;
using Profile = AutoMapper.Profile;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseProject.Infrastructure.MappingProfiles
{
    public class PostMappingProfile : Profile
    {
        public PostMappingProfile()
        {
            MapPostToPosViewModel();
            MapPostViewModelToPost();
        }

        private void MapPostToPosViewModel()
        {
            CreateMap<Post, PostViewModel>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, c => c.MapFrom(src => src.Title))
                .ForMember(dest => dest.SubTitle, c => c.MapFrom(src => src.SubTitle))
                .ForMember(dest => dest.Content, c => c.MapFrom(src => src.Content))
                .ForMember(dest => dest.UserId, c => c.MapFrom(src => src.UserId))
                .ForMember(dest => dest.UserName, c => c.MapFrom(src => src.User.UserName))
                .ForMember(dest => dest.ProjectId, c => c.MapFrom(src => src.ProjectId))
                .ForAllOtherMembers(c => c.Ignore());
        }

        private void MapPostViewModelToPost()
        {
            CreateMap<PostViewModel, Post>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, c => c.MapFrom(src => src.Title))
                .ForMember(dest => dest.SubTitle, c => c.MapFrom(src => src.SubTitle))
                .ForMember(dest => dest.Content, c => c.MapFrom(src => src.Content))
                .ForMember(dest => dest.UserId, c => c.MapFrom(src => src.UserId))
                //.ForPath(dest => dest.User.UserName, c => c.MapFrom(src => src.UserName))
                .ForMember(dest => dest.ProjectId, c => c.MapFrom(src => src.ProjectId))
                .ForAllOtherMembers(c => c.Ignore());
        }
    }
}
