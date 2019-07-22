using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts
{
    public interface IContentService
    {
        ContentViewModel Get(int projectId);
        int Add(ContentViewModel viewModel);
        int Update(ContentViewModel viewModel);
    }
}
