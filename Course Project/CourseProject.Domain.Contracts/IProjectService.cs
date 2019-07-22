using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts
{
    public interface IProjectService
    {
        ProjectViewModel Get(int id);
        IEnumerable<ProjectViewModel> GetAll();
        int Add(ProjectViewModel projectViewModel);
        void Remove(int id);
        void Update(ProjectViewModel projectViewModel);
    }
}
