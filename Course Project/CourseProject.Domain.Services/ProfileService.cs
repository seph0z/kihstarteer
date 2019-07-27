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
    public class ProfileService : IProfileService
    {
        private readonly IRepository<Profile> repository;
        public ProfileService(IRepository<Profile> repository)
        {
            this.repository = repository;
        }
        public void Add(ProfileViewModel viewModel)
        {
            var profile = AutoMapper.Mapper.Map<Profile>(viewModel);
            repository.Add(profile);
            repository.SaveChanges();
        }

        public ProfileViewModel Get(string id)
        {
            var profile = repository.GetAll().ToList().Find(x => x.UserId == id);
            if (profile == null)
                return null;
            var profileViewModel = AutoMapper.Mapper.Map<ProfileViewModel>(profile);
            return profileViewModel;
        }

        public void Update(ProfileViewModel viewModel)
        {
            var profile = AutoMapper.Mapper.Map<Profile>(viewModel);
            repository.Update(profile);
            repository.SaveChanges();
        }
    }
}
