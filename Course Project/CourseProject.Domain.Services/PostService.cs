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
    public class PostService : IPostService
    {
        private readonly IRepository<Post> repository;
        public PostService(IRepository<Post> repository)
        {
            this.repository = repository;
        }

        public int Add(PostViewModel postView)
        {
            var post = Mapper.Map<Post>(postView);
            repository.Add(post);
            repository.SaveChanges();
            return post.Id;
        }

        public PostViewModel Get(int id)
        {
            var post = repository.Get(id);
            var viewModel = Mapper.Map<PostViewModel>(post);
            return viewModel;
        }

        public IEnumerable<PostViewModel> GetAll(int projectId)
        {
            var postForProject = repository.GetAll().ToList().FindAll(x => x.ProjectId == projectId);
            IEnumerable<PostViewModel> postViewModels = Mapper.Map<IEnumerable<Post>, IEnumerable<PostViewModel>>(postForProject);
            return postViewModels;

        }

        public void Remove(int id)
        {
            repository.Remove(id);
            repository.SaveChanges();
        }

        public int Update(PostViewModel postView)
        {
            var post = Mapper.Map<Post>(postView);
            repository.Update(post);
            repository.SaveChanges();
            return post.Id;
        }
    }
}
