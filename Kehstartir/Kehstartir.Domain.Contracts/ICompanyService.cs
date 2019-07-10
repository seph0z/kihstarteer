using Kehstartir.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Domain.Contracts
{
    public interface ICompanyService
    {
        CompanyViewModel Get(int id);
        IEnumerable<CompanyViewModel> GetAll();
        void Add(CompanyViewModel companyViewModel);
        void Remove(int id);
        void Update(CompanyViewModel companyViewModel);
        //void SaveChanges();
    }
}
