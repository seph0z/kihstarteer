using AutoMapper;
using CourseProject.Data.Contracts;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts;
using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseProject.Domain.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IRepository<Project> _repository;
        private readonly IRepository<Tag> tagRepository;
        public ProjectService(IRepository<Project> repository,
            IRepository<Tag> tagRepository)
        {
            _repository = repository;
            this.tagRepository = tagRepository;
        }

        public int Add(ProjectViewModel projectViewModel)
        {

            var project = Mapper.Map<Project>(projectViewModel);
            _repository.Add(project);
            _repository.SaveChanges();

            AddTags(projectViewModel.Tags, project.Id);
            
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

        public IEnumerable<string> Tags()
        {
            var tags = tagRepository.GetAll();
            List<string> forProject = new List<string>();
            foreach(var tag in tags)
            {
                forProject.Add(tag.Text);
            }
            return forProject;
        }

        public int Update(ProjectViewModel projectViewModel)
        {
            var project = Mapper.Map<Project>(projectViewModel);
            _repository.Update(project);
            _repository.SaveChanges();
            return project.Id;
        }

        private void AddTags(string[] tags, int projectId)
        {
            if (tags == null)
                return;
            foreach (var tag in tags)
            {
                if (tagRepository.GetAll().ToList().Find(x => x.Text == tag) == null)
                {
                    tagRepository.Add(new Tag
                    {
                        Text = tag,
                        ProjectTags = new List<ProjectTag>
                        {
                            new ProjectTag {ProjectId = projectId}
                        }
                    });
                }
                else
                {
                    var tagAdd = tagRepository.GetAll().ToList().Find(x => x.Text == tag);
                    tagAdd.ProjectTags.Add(new ProjectTag { ProjectId = projectId });
                    tagRepository.Update(tagAdd);
                    tagRepository.SaveChanges();
                }
            }
            tagRepository.SaveChanges();
        }


    }
}
