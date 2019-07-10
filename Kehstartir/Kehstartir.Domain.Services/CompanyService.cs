using AutoMapper;
using Kehstartir.Data.Contracts;
using Kehstartir.Data.Contracts.Entities;
using Kehstartir.Domain.Contracts;
using Kehstartir.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Domain.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IRepository<Company> repository;
        public CompanyService(IRepository<Company> repository)
        {
            this.repository = repository;
        }

        public void Add(CompanyViewModel companyViewModel)
        {
            var company = Mapper.Map<Company>(companyViewModel);
            repository.Add(company);
            repository.SaveChanges();
        }

        public CompanyViewModel Get(int id)
        {
            Company company = repository.Get(id);
            var result = Mapper.Map<CompanyViewModel>(company);
            return result;
        }

        public IEnumerable<CompanyViewModel> GetAll()
        {
            var companies = repository.GetAll();
            IEnumerable<CompanyViewModel> companyViewModels = Mapper.Map<IEnumerable<Company>, IEnumerable<CompanyViewModel>>(companies);
            return companyViewModels;
        }

        public void Remove(int id)
        {
            repository.Remove(id);
            repository.SaveChanges();
        }

        public void Update(CompanyViewModel companyViewModel)
        {
            var company = Mapper.Map<Company>(companyViewModel);
            repository.Update(company);
            repository.SaveChanges();
        }
    }
}
