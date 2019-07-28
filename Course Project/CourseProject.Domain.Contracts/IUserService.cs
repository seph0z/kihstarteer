using CourseProject.Domain.Contracts.ViewModels;
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
    }
}
