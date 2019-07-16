using Kehstartir.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Domain.Contracts
{
    public interface ICampaignService
    {
        CampaignViewModel Get(int id);
        IEnumerable<CampaignViewModel> GetAll();
        void Add(CampaignViewModel companyViewModel);
        void Remove(int id);
        void Update(CampaignViewModel companyViewModel);
    }
}
