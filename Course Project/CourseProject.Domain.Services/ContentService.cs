using AutoMapper;
using CourseProject.Data.Contracts;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Data.EntityFramework;
using CourseProject.Domain.Contracts;
using CourseProject.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseProject.Domain.Services
{
    public class ContentService : IContentService
    {
        private readonly IRepository<Content> _contentRepository;
        public ContentService(IRepository<Content> contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public int Add(ContentViewModel viewModel)
        {
            var content = Mapper.Map<Content>(viewModel);
            _contentRepository.Add(content);
            _contentRepository.SaveChanges();
            return content.ProjectId;
        }

        public ContentViewModel Get(int projectId)
        {
            var content = _contentRepository.GetAll()
                .ToList()
                .Find(x => x.ProjectId == projectId);
            if (content == null)
                return null;
            var viewModel = Mapper.Map<ContentViewModel>(content);
            return viewModel;
        }

        public int Update(ContentViewModel viewModel)
        {
            var content = Mapper.Map<Content>(viewModel);
            _contentRepository.Update(content);
            _contentRepository.SaveChanges();
            return content.ProjectId; ;
        }
    }
}
