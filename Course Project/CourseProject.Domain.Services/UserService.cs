using AutoMapper;
using CourseProject.Data.Contracts;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Data.EntityFramework;
using CourseProject.Domain.Contracts;
using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly CourseProjectDbContext dbContext;
        public UserService(CourseProjectDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public UserViewModel Get(string id)
        {
            var user = dbContext.AspNetUsers.Find(id);
            var userViewModel = new UserViewModel
            {
                Id = user.Id,
                Name = user.UserName,
                Image = user.Image,
                Biography = user.Biography,
                Country = user.Country
            };
            return userViewModel;

        }

        public void Update(UserViewModel viewModel)
        {
            var user = dbContext.AspNetUsers.Find(viewModel.Id);
            user.UserName = viewModel.Name;
            user.Image = viewModel.Image;
            user.Biography = viewModel.Biography;
            user.Country = viewModel.Country;
            dbContext.SaveChanges();
        }

        public IEnumerable<ProjectViewModel> GetProjects(string userId)
        {
            var user = dbContext.AspNetUsers.Find(userId);
            var projects = Mapper.Map<IEnumerable<Project>, IEnumerable<ProjectViewModel>>(user.Projects);
            return projects;   
        }
    }
}
