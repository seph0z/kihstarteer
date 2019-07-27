using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
using Markdig;

namespace CourseProject.Web.Controllers
{
    public class ShowController : Controller
    {
        private readonly IShowProjectService showProjectService;
        public ShowController(IShowProjectService showProjectService)
        {
            this.showProjectService = showProjectService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get(int Id)
        {
            var project = showProjectService.Get(Id);
            ViewBag.Percent = (project.CurrentFunding * 100) / project.Funding;
            project.Content = Markdown.ToHtml(project.Content);
            return View(project);
        }
    }
}