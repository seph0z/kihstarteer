using AutoMapper;
using Profile = AutoMapper.Profile;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts.ViewModels;

namespace CourseProject.Infrastructure.MappingProfiles
{
    public class ProjectMappingProfile : Profile
    {
        public ProjectMappingProfile()
        {
            MapProjectToProjectViewModel();
            MapProjectViewModelToProject();
            MapProjectTagToString();
        }

        private void MapProjectToProjectViewModel()
        {
            CreateMap<Project, ProjectViewModel>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, c => c.MapFrom(src => src.Title))
                .ForMember(dest => dest.Subtitle, c => c.MapFrom(src => src.Subtitle))
                .ForMember(dest => dest.Image, c => c.MapFrom(src => src.Image))
                .ForMember(dest => dest.Video, c => c.MapFrom(src => src.Video))
                .ForMember(dest => dest.CurrentFunding, c => c.MapFrom(src => src.CurrentFunding))
                .ForMember(dest => dest.Funding, c => c.MapFrom(src => src.Funding))
                .ForMember(dest => dest.Duration, c => c.MapFrom(src => src.Duration))
                .ForMember(dest => dest.UserId, c => c.MapFrom(src => src.UserId))
                .ForMember(dest => dest.CategoryId, c => c.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.Tags, c => c.MapFrom(src => src.ProjectTags))
                .ForAllOtherMembers(c => c.Ignore());
        }

        private void MapProjectViewModelToProject()
        {
            CreateMap<ProjectViewModel, Project>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, c => c.MapFrom(src => src.Title))
                .ForMember(dest => dest.Subtitle, c => c.MapFrom(src => src.Subtitle))
                .ForMember(dest => dest.Image, c => c.MapFrom(src => src.Image))
                .ForMember(dest => dest.Video, c => c.MapFrom(src => src.Video))
                .ForMember(dest => dest.Funding, c => c.MapFrom(src => src.Funding))
                .ForMember(dest => dest.CurrentFunding, c => c.MapFrom(src => src.CurrentFunding))
                .ForMember(dest => dest.Duration, c => c.MapFrom(src => src.Duration))
                .ForMember(dest => dest.UserId, c => c.MapFrom(src => src.UserId))
                .ForPath(dest => dest.CategoryId, c => c.MapFrom(src => src.CategoryId))
                .ForAllOtherMembers(c => c.Ignore());
        }

        public void MapProjectTagToString()
        {
            CreateMap<ProjectTag, string>()
                .ConvertUsing(new StringProjectTagConverter());
        }
    }

    public class StringProjectTagConverter : ITypeConverter<ProjectTag, string>
    {
        public string Convert(ProjectTag source, string destination, ResolutionContext context)
        {
            return source.Tag.Text;
        }
    }
}
