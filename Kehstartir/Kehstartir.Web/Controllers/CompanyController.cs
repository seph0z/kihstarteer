using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Kehstartir.Domain.Contracts;
using Kehstartir.Domain.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Kehstartir.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService companyService;
        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CompanyViewModel companyViewModel)
        {
            companyViewModel.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            companyService.Add(companyViewModel);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}