using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts
{
    public interface IShowProjectService
    {
        ShowProjectViewModel Get(int id);
        double AddMoney(double Count, int projectId);
        IEnumerable<ShowProjectViewModel> GetAll();
        IEnumerable<ShowProjectViewModel> GetForFind(string text);
        IEnumerable<ShowProjectViewModel> GetForCategory(string category);
        IEnumerable<ShowProjectViewModel> GetTag(string tag);
        IEnumerable<string> GetCloudTags();
    }
}
