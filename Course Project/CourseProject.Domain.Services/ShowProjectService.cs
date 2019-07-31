using AutoMapper;
using CourseProject.Data.Contracts;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts;
using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Services
{
    public class ShowProjectService : IShowProjectService
    {
        private readonly IRepository<Project> repository;
        public ShowProjectService(IRepository<Project> repository)
        {
            this.repository = repository;
        }

        public double AddMoney(double Count, int projectId)
        {
            var project = repository.Get(projectId);
            project.CurrentFunding += Count;
            repository.Update(project);
            repository.SaveChanges();
            return project.CurrentFunding;
        }

        public ShowProjectViewModel Get(int id)
        {
            var project = repository.Get(id);
            var result = Mapper.Map<ShowProjectViewModel>(project);
            return result;
        }
    }
}
