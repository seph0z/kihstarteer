using CourseProject.Domain.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts
{
    public interface IUserService
    {
        UserViewModel Get(string id);
        void Update(UserViewModel viewModel);
        IEnumerable<ProjectViewModel> GetProjects(string userId);
        IEnumerable<UserViewModel> GetUsers();
        void AddRole(string id, string role);
        void Remove(string id);
        List<SelectListItem> GetRoles();
        void AddReward(int rewardId, string userId);
        IEnumerable<RewardViewModel> GetRewards(string userId);
    }
}
