using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts
{
    public interface IPostService
    {
        int Add(PostViewModel postView);
        int Update(PostViewModel postView);
        void Remove(int id);
        PostViewModel Get(int id);
        IEnumerable<PostViewModel> GetAll(int projectId);
    }
}
