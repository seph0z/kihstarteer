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
using Microsoft.AspNetCore.Mvc.Rendering;

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
            //campaignViewModel.Id = 2;
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
            //campaignService.Remove(2);
            //var camp = campaignService.Get(2);
            var col = new List<SelectListItem>()
            {
                new SelectListItem{Text = "Games", Value = "1" },
                new SelectListItem{Text = "Clothes", Value = "2" },
                new SelectListItem{Text = "Electronics", Value = "3" },
                new SelectListItem{Text = "Food", Value = "4", Selected = true },
                new SelectListItem{Text = "Films", Value = "5" },
                new SelectListItem{Text = "Music", Value = "6" }
            };
            ViewBag.Select = col;
            return View();
        }
    }
}