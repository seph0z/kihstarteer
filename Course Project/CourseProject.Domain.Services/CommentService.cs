using AutoMapper;
using CourseProject.Data.Contracts;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts;
using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CourseProject.Domain.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> repository;
        public CommentService(IRepository<Comment> repository)
        {
            this.repository = repository;
        }
        public void Add(CommentViewModel viewMode)
        {
            var comment = Mapper.Map<Comment>(viewMode);
            repository.Add(comment);
            repository.SaveChanges();
        }

        public IEnumerable<CommentViewModel> GetAll(int projectId)
        {
            var comments = repository.GetAll().ToList().FindAll(x => x.ProjectId == projectId);
            IEnumerable<CommentViewModel> viewModels = Mapper.Map<IEnumerable<Comment>, IEnumerable<CommentViewModel>>(comments);
            return viewModels;
        }

        public void Remove(int id)
        {
            repository.Remove(id);
            repository.SaveChanges();
        }
    }
}
