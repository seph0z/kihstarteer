using AutoMapper;
using Profile = AutoMapper.Profile;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts.ViewModels;

namespace CourseProject.Infrastructure.MappingProfiles
{
    public class RewardMappingProfile : Profile
    {
        public RewardMappingProfile()
        {
            MapRewardToRewardViewModel();
            MapRewardViewModelToReward();
        }

        private void MapRewardToRewardViewModel()
        {
            CreateMap<Reward, RewardViewModel>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, c => c.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, c => c.MapFrom(src => src.Description))
                .ForMember(dest => dest.Amount, c => c.MapFrom(src => src.Amount))
                .ForMember(dest => dest.ProjectId, c => c.MapFrom(src => src.ProjectId))
                .ForAllOtherMembers(c => c.Ignore());

        }

        private void MapRewardViewModelToReward()
        {
            CreateMap<RewardViewModel, Reward>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, c => c.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, c => c.MapFrom(src => src.Description))
                .ForMember(dest => dest.Amount, c => c.MapFrom(src => src.Amount))
                .ForMember(dest => dest.ProjectId, c => c.MapFrom(src => src.ProjectId))
                .ForAllOtherMembers(c => c.Ignore());
        }
    }
}
