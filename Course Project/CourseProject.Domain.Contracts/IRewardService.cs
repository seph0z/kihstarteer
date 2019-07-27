using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts
{
    public interface IRewardService
    {
        IEnumerable<RewardViewModel> GetAll(int projectId);
        RewardViewModel Get(int rewardId);
        void Add(RewardViewModel viewModel);
        void Delete(int rewardId);
        void Update(RewardViewModel viewModel);
    }
}
