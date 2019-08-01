using AutoMapper;
using CourseProject.Data.Contracts;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Data.EntityFramework;
using CourseProject.Domain.Contracts;
using CourseProject.Domain.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if (user == null)
                return null;
            if(user.AspNetUserRoles.Count == 0)
            {
                var role = dbContext.AspNetRoles.ToList().Find(x => x.Name == "User");
                user.AspNetUserRoles.Add(new AspNetUserRoles { UserId = user.Id, RoleId = role.Id });
                dbContext.SaveChanges();
            }
            var userViewModel = new UserViewModel
            {
                Id = user.Id,
                Name = user.UserName,
                Image = user.Image,
                Biography = user.Biography,
                Country = user.Country,
                Role = user.AspNetUserRoles.FirstOrDefault(x => x.UserId == user.Id).Role.Name
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
            AddRole(viewModel.Id, viewModel.Role);

            dbContext.SaveChanges();
        }

        public IEnumerable<ProjectViewModel> GetProjects(string userId)
        {
            var user = dbContext.AspNetUsers.Find(userId);
            var projects = Mapper.Map<IEnumerable<Project>, IEnumerable<ProjectViewModel>>(user.Projects);
            return projects;
        }

        public IEnumerable<UserViewModel> GetUsers()
        {
            var users = dbContext.AspNetUsers;
            var usersViewModel = Mapper.Map<IEnumerable<AspNetUsers>, IEnumerable<UserViewModel>>(users);
            return usersViewModel;
        }

        public void Remove(string id)
        {
            var user = dbContext.AspNetUsers.Find(id);
            dbContext.Remove(user);
            dbContext.SaveChanges();
        }

        public void AddRole(string id, string userRole)
        {
            var user = dbContext.AspNetUsers.Find(id);
            var role = dbContext.AspNetRoles.ToList().Find(x => x.Name == userRole);
            user.AspNetUserRoles.Remove(user.AspNetUserRoles.First());
            user.AspNetUserRoles.Add(new AspNetUserRoles { UserId = id, RoleId = role.Id });
            dbContext.SaveChanges();
        }

        public List<SelectListItem> GetRoles()
        {
            var roles = dbContext.AspNetRoles.ToList();
            List<SelectListItem> selectLists = new List<SelectListItem>();
            foreach(var role in roles)
            {
                selectLists.Add(new SelectListItem
                {
                    Value = role.Name,
                    Text = role.Name
                });
            }
            return selectLists;
        }

        public void AddReward(int rewardId, string userId)
        {
            dbContext.RewardAspNetUsers.Add(new RewardAspNetUsers { RewardId = rewardId, UserId = userId });
            dbContext.SaveChanges();
        }

        public IEnumerable<RewardViewModel> GetRewards(string userId)
        {
            var rewardsAspUsers = dbContext.AspNetUsers.Find(userId).RewardAspNetUsers;
            var reward = Mapper.Map<IEnumerable<RewardAspNetUsers>, IEnumerable<Reward>>(rewardsAspUsers);
            var rewardViewModel = Mapper.Map<IEnumerable<Reward>, IEnumerable<RewardViewModel>>(reward);
            return rewardViewModel;
        }
    }
}
