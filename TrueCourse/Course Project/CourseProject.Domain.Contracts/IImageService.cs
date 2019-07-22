using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts
{
    public interface IImageService
    {
        ICollection<ImageViewModel> GetAll(int projectId);
        int Add(ImageViewModel viewModel, int projectId);
        int AddRange(ICollection<ImageViewModel> viewModels, int projectId);
        int UpdateRange(ICollection<ImageViewModel> viewModels, int projectId);
        void Remove(int id);
        void AddList(ICollection<string> images, int projectId);
        void UpdateList(ICollection<string> images, int projectId);
        ICollection<string> GetAllList(int projectId);
    }
}
