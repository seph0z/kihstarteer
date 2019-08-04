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
    public class ShowProjectService : IShowProjectService
    {
        private readonly IRepository<Project> repository;
        private readonly IRepository<Tag> tagRepository;
        public ShowProjectService(IRepository<Project> repository,
            IRepository<Tag> tagRepository)
        {
            this.tagRepository = tagRepository;
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

        public IEnumerable<ShowProjectViewModel> GetAll()
        {
            var projects = repository.GetAll();
            var showProjectViewModels = Mapper.Map<IEnumerable<Project>, IEnumerable<ShowProjectViewModel>>(projects);
            return showProjectViewModels;
        }

        public IEnumerable<string> GetCloudTags()
        {
            var dictTag = new Dictionary<int, string>();
            var tags = tagRepository.GetAll();

            var sortedDict = from entry in tags
                             orderby entry.ProjectTags.Count()
                             descending
                             select entry;

            List<string> cloudTags = new List<string>();
            
            foreach(var tag in sortedDict)
            {
                cloudTags.Add(tag.Text);
            }

            return cloudTags.Take(10).ToList();
        }

        public IEnumerable<ShowProjectViewModel> GetForCategory(string category)
        {
            var projects = GetAll().ToList().FindAll(x => x.Category == category);
            return projects;
        }

        public IEnumerable<ShowProjectViewModel> GetForFind(string text)
        {
            var projects = GetAll().ToList().FindAll(x => x.Title.Contains(text) 
            || x.Subtitle.Contains(text));
            return projects;
        }

        public IEnumerable<ShowProjectViewModel> GetTag(string tag)
        {
            var projects = GetAll().ToList().FindAll(x => x.Tags.Contains(tag));
            return projects;
        }
    }
}
