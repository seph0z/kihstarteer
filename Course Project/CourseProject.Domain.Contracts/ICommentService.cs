using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Contracts
{
    public interface ICommentService
    {
        void Add(CommentViewModel viewMode);
        void Remove(int id);
        IEnumerable<CommentViewModel> GetAll(int projectId);
    }
}
