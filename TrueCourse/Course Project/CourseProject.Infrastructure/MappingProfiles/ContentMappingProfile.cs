using AutoMapper;
using Profile = AutoMapper.Profile;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts.ViewModels;

namespace CourseProject.Infrastructure.MappingProfiles
{
    public class ContentMappingProfile : Profile
    {
        public ContentMappingProfile()
        {
            MapContentToContentViewModel();
            MapContentViewModelToContent();
        }

        private void MapContentToContentViewModel()
        {
            CreateMap<Content, ContentViewModel>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Content, c => c.MapFrom(src => src.Text))
                .ForMember(dest => dest.ProjectId, c => c.MapFrom(src => src.ProjectId))
                .ForAllOtherMembers(c => c.Ignore());
        }

        private void MapContentViewModelToContent()
        {
            CreateMap<ContentViewModel, Content>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Text, c => c.MapFrom(src => src.Content))
                .ForMember(dest => dest.ProjectId, c => c.MapFrom(src => src.ProjectId))
                .ForAllOtherMembers(c => c.Ignore());
        }
    }
}
