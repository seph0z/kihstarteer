﻿using AutoMapper;
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
    public class ImageService : IImageService
    {
        private readonly IRepository<Image> _repository;
        public ImageService(IRepository<Image> repository)
        {
            _repository = repository;
        }

        public void UpdateList(ICollection<string> images, int projectId)
        {
            var imagesList = _repository.GetAll().ToList().FindAll(x => x.ProjectId == projectId);
            _repository.RemoveRange(imagesList);
            AddList(images, projectId);
        }

        public void AddList(ICollection<string> images, int projectId)
        {
            IEnumerable<Image> imagesList = Mapper.Map<IEnumerable<string>, IEnumerable<Image>>(images);
            imagesList.ToList().ForEach(x => x.ProjectId = projectId);
            _repository.AddRange(imagesList);
            _repository.SaveChanges();
        }

        public ICollection<string> GetAllList(int projectId)
        {
            var images = _repository.GetAll().ToList().FindAll(x => x.ProjectId == projectId);
            IEnumerable<string> imageList = Mapper.Map<IEnumerable<Image>, IEnumerable<string>>(images);
            return imageList.ToList();
        }
    }
}