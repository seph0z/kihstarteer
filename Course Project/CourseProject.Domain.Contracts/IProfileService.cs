using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts
{
    public interface IProfileService
    {
        ProfileViewModel Get(string id);
        void Add(ProfileViewModel viewModel);
        void Update(ProfileViewModel viewModel);
    }
}
