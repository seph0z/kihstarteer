using AutoMapper;
using Profile = AutoMapper.Profile;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts.ViewModels;

namespace CourseProject.Infrastructure.MappingProfiles
{
    public class CommentMappingProfile : Profile
    {
        public CommentMappingProfile()
        {
            MapCommentToCommentViewModel();
            MapCommentViewModelToComment();
        }

        private void MapCommentToCommentViewModel()
        {
            CreateMap<Comment, CommentViewModel>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Text, c => c.MapFrom(src => src.Text))
                .ForMember(dest => dest.UserId, c => c.MapFrom(src => src.UserId))
                .ForMember(dest => dest.UserName, c => c.MapFrom(src => src.User.UserName))
                .ForMember(dest => dest.ProjectId, c => c.MapFrom(src => src.ProjectId))
                .ForAllOtherMembers(c => c.Ignore());

        }

        private void MapCommentViewModelToComment()
        {
            CreateMap<CommentViewModel, Comment>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Text, c => c.MapFrom(src => src.Text))
                .ForMember(dest => dest.UserId, c => c.MapFrom(src => src.UserId))
                //.ForPath(dest => dest.User.UserName, c => c.MapFrom(src => src.UserName))
                .ForMember(dest => dest.ProjectId, c => c.MapFrom(src => src.ProjectId))
                .ForAllOtherMembers(c => c.Ignore());
        }
    }
}
