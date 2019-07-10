using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kehstartir.Web.Models;
using Kehstartir.Domain.Contracts;
using Kehstartir.Domain.Contracts.ViewModels;
using System.Security.Claims;

namespace Kehstartir.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICompanyService companyService;
        public HomeController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            companyService.Add(new CompanyViewModel
            {
                Title = "Title",
                Description = "Desc",
                VideoLink = "Videpli",
                Amount = 5,
                ExpirationDate = DateTime.Now,
                Theme = "Theme",
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                Tags = new string[] { "qwe", "rty" },
                Rating = 5
            });
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
