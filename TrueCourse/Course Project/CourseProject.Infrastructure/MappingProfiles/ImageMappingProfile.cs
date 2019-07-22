using System;
using System.Collections.Generic;
using System.Text;
using Profile = AutoMapper.Profile;
using AutoMapper;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts.ViewModels;

namespace CourseProject.Infrastructure.MappingProfiles
{
    public class ImageMappingProfile : Profile
    {
        public ImageMappingProfile()
        {
            MapImageToImageViewModel();
            MapImageViewModelToImage();
            MapImageToString();
            MapStringToImage();
        }

        private void MapImageToImageViewModel()
        {
            CreateMap<Image, ImageViewModel>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Path, c => c.MapFrom(src => src.Path))
                .ForMember(dest => dest.ProjectId, c => c.MapFrom(src => src.ProjectId))
                .ForAllOtherMembers(c => c.Ignore());
        }

        private void MapImageViewModelToImage()
        {
            CreateMap<ImageViewModel, Image>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Path, c => c.MapFrom(src => src.Path))
                .ForMember(dest => dest.ProjectId, c => c.MapFrom(src => src.ProjectId))
                .ForAllOtherMembers(c => c.Ignore());
        }

        private void MapImageToString()
        {
            CreateMap<Image, string>()
                .ConvertUsing(new ImageStringConvert());
        }

        private void MapStringToImage()
        {
            CreateMap<string, Image>()
                .ConvertUsing(new StringImageConvert());
        }
    }

    public class ImageStringConvert : ITypeConverter<Image, string>
    {
        public string Convert(Image source, string destination, ResolutionContext context)
        {
            var image = source.Path;
            return image;
        }
    }

    public class StringImageConvert : ITypeConverter<string, Image>
    {
        public Image Convert(string source, Image destination, ResolutionContext context)
        {
            var image = new Image { Path = source };
            return image;
        }
    }

}
