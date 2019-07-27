using System;
using System.Collections.Generic;
using System.Text;
using Profile = AutoMapper.Profile;
using AutoMapper;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts.ViewModels;

namespace CourseProject.Infrastructure.MappingProfiles
{
    public class ShowProjectMappingProfile : Profile
    {
        public ShowProjectMappingProfile()
        {
            MapProjectToShowProjectViewModel();
            MapShowProjectViewModelToProject();
            MapStringToImage();
            MapImageToString();
            MapStringToProjectTag();
        }

        private void MapProjectToShowProjectViewModel()
        {
            CreateMap<Project, ShowProjectViewModel>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, c => c.MapFrom(src => src.Title))
                .ForMember(dest => dest.Subtitle, c => c.MapFrom(src => src.Subtitle))
                .ForMember(dest => dest.Image, c => c.MapFrom(src => src.Image))
                .ForMember(dest => dest.Video, c => c.MapFrom(src => src.Video))
                .ForMember(dest => dest.CurrentFunding, c => c.MapFrom(src => src.CurrentFunding))
                .ForMember(dest => dest.Funding, c => c.MapFrom(src => src.Funding))
                .ForMember(dest => dest.Duration, c => c.MapFrom(src => src.Duration))
                .ForMember(dest => dest.Content, c => c.MapFrom(src => src.Content.Text))
                .ForMember(dest => dest.Category, c => c.MapFrom(src => src.Category.Section))
                .ForMember(dest => dest.User, c => c.MapFrom(src => src.User.UserName))
                .ForMember(dest => dest.Rewards, c => c.MapFrom(src => src.Rewards))
                .ForMember(dest => dest.Images, c => c.MapFrom(src => src.Images))
                .ForMember(dest => dest.Tags, c => c.MapFrom(src => src.ProjectTags))
                .ForAllOtherMembers(c => c.Ignore());
        }

        private void MapShowProjectViewModelToProject()
        {
            CreateMap<ShowProjectViewModel, Project>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, c => c.MapFrom(src => src.Title))
                .ForMember(dest => dest.Subtitle, c => c.MapFrom(src => src.Subtitle))
                .ForMember(dest => dest.Image, c => c.MapFrom(src => src.Image))
                .ForMember(dest => dest.Video, c => c.MapFrom(src => src.Video))
                .ForMember(dest => dest.CurrentFunding, c => c.MapFrom(src => src.CurrentFunding))
                .ForMember(dest => dest.Funding, c => c.MapFrom(src => src.Funding))
                .ForMember(dest => dest.Duration, c => c.MapFrom(src => src.Duration))
                .ForPath(dest => dest.Content.Text, c => c.MapFrom(src => src.Content))
                .ForPath(dest => dest.Category.Section, c => c.MapFrom(src => src.Category))
                .ForPath(dest => dest.User.UserName, c => c.MapFrom(src => src.User))
                .ForMember(dest => dest.Rewards, c => c.MapFrom(src => src.Rewards))
                .ForMember(dest => dest.Images, c => c.MapFrom(src => src.Images))
                .ForMember(dest => dest.ProjectTags, c => c.MapFrom(src => src.Tags))
                .ForAllOtherMembers(c => c.Ignore());
        }

        private void MapStringToImage()
        {
            CreateMap<string, Image>()
                .ConvertUsing(new ImagesStringConvert());
        }

        private void MapImageToString()
        {
            CreateMap<Image, string>()
                .ConvertUsing(new StringImagesConvert());
        }

        private void MapStringToProjectTag()
        {
            CreateMap<string, ProjectTag>()
                .ConvertUsing(new ProjectTagStringConvert());
        }
    }

    public class ImagesStringConvert : ITypeConverter<string, Image>
    {
        public Image Convert(string source, Image destination, ResolutionContext context)
        {
            return new Image { Path = source };
        }
    }

    public class StringImagesConvert : ITypeConverter<Image, string>
    {
        public string Convert(Image source, string destination, ResolutionContext context)
        {
            return source.Path;
        }
    }

    public class ProjectTagStringConvert : ITypeConverter<string, ProjectTag>
    {
        public ProjectTag Convert(string source, ProjectTag destination, ResolutionContext context)
        {
            return new ProjectTag { Tag = new Tag { Text = source } };
        }
    }
}
