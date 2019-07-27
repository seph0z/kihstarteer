using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts
{
    public interface IImageService
    {
        void AddList(ICollection<string> images, int projectId);
        void UpdateList(ICollection<string> images, int projectId);
        ICollection<string> GetAllList(int projectId);
    }
}
