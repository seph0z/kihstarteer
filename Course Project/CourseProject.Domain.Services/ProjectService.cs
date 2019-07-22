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
    public class ProjectService : IProjectService
    {
        private readonly IRepository<Project> _repository;
        public ProjectService(IRepository<Project> repository)
        {
            _repository = repository;
        }

        public int Add(ProjectViewModel projectViewModel)
        {
            var project = Mapper.Map<Project>(projectViewModel);
            _repository.Add(project);
            _repository.SaveChanges();
            return project.Id;
        }

        public ProjectViewModel Get(int id)
        {
            var project = _repository.Get(id);
            var result = Mapper.Map<ProjectViewModel>(project);
            return result;
        }

        public IEnumerable<ProjectViewModel> GetAll()
        {
            var projects = _repository.GetAll();
            IEnumerable<ProjectViewModel> projectViewModels = Mapper.Map<IEnumerable<Project>, IEnumerable<ProjectViewModel>>(projects);
            return projectViewModels;
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
            _repository.SaveChanges();
        }

        public void Update(ProjectViewModel projectViewModel)
        {
            var project = Mapper.Map<Project>(projectViewModel);
            _repository.Update(project);
            _repository.SaveChanges();
        }
    }
}
