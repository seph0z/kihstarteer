using AutoMapper;
using Profile = AutoMapper.Profile;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseProject.Infrastructure.MappingProfiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            MapCategorieToSelectListIthem();
        }

        private void MapCategorieToSelectListIthem()
        {
            CreateMap<Category, SelectListItem>()
                .ForMember(dest => dest.Value, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Text, c => c.MapFrom(src => src.Section))
                .ForAllOtherMembers(c => c.Ignore());

        }
    }
}
