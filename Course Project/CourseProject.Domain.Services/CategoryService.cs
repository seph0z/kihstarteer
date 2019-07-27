using AutoMapper;
using CourseProject.Data.Contracts;
using CourseProject.Data.Contracts.Entities;
using CourseProject.Domain.Contracts;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseProject.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repository;
        public CategoryService(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public List<SelectListItem> GetAll()
        {
            var categories = _repository.GetAll();
            IEnumerable<SelectListItem> result = Mapper.Map<IEnumerable<Category>, IEnumerable<SelectListItem>>(categories);
            return result.ToList();
        }
    }
}
