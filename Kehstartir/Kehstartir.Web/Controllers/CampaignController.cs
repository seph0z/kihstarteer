using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Kehstartir.Domain.Contracts;
using Kehstartir.Domain.Contracts.ViewModels;
using Kehstartir.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kehstartir.Web.Controllers
{
    public class CampaignController : Controller
    {
        private readonly ICampaignService campaignService;
        public CampaignController(ICampaignService campaignService)
        {
            this.campaignService = campaignService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CampaignViewModel campaignViewModel)
        {
            campaignViewModel.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            campaignService.Add(campaignViewModel);
            return RedirectToAction("Index");
        }

        public IActionResult PreViewImage(List<IFormFile> formFiles)
        {
            var dbx = new DropboxWorker();
            dbx.Add(formFiles);
            return PartialView(dbx.GetPath(formFiles));
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}