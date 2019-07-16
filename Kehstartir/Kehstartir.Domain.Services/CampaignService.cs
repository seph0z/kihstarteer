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
    public class CampaignService : ICampaignService
    {
        private readonly IRepository<Campaign> repository;
        public CampaignService(IRepository<Campaign> repository)
        {
            this.repository = repository;
        }

        public void Add(CampaignViewModel companyViewModel)
        {
            var company = Mapper.Map<Campaign>(companyViewModel);
            repository.Add(company);
            repository.SaveChanges();
        }

        public CampaignViewModel Get(int id)
        {
            Campaign company = repository.Get(id);
            var result = Mapper.Map<CampaignViewModel>(company);
            return result;
        }

        public IEnumerable<CampaignViewModel> GetAll()
        {
            var companies = repository.GetAll();
            IEnumerable<CampaignViewModel> companyViewModels = Mapper.Map<IEnumerable<Campaign>, IEnumerable<CampaignViewModel>>(companies);
            return companyViewModels;
        }

        public void Remove(int id)
        {
            repository.Remove(id);
            repository.SaveChanges();
        }

        public void Update(CampaignViewModel companyViewModel)
        {
            var company = Mapper.Map<Campaign>(companyViewModel);
            repository.Update(company);
            repository.SaveChanges();
        }
    }
}
