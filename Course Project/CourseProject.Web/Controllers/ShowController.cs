using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
using Markdig;
using CourseProject.Domain.Contracts.ViewModels;
using System.Security.Claims;

namespace CourseProject.Web.Controllers
{
    public class ShowController : Controller
    {
        private readonly IShowProjectService showProjectService;
        private readonly IPostService postService;
        public ShowController(
            IShowProjectService showProjectService,
            IPostService postService
            )
        {
            this.showProjectService = showProjectService;
            this.postService = postService;
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

        public IActionResult AddPost(int projectId)
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddPost(PostViewModel viewModel)
        {
            viewModel.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var postId = postService.Add(viewModel);
            return RedirectToAction("GetPost", new { id = postId });
        }

        public IActionResult GetPost(int id)
        {
            var post = postService.Get(id);
            return View(post);
        }

        public IActionResult Remove(int id)
        {
            var projectId = postService.Get(id).ProjectId;
            postService.Remove(id);
            return RedirectToAction("Get", new { Id = projectId });
        }

        public IActionResult Update(int id)
        {
            var post = postService.Get(id);
            return View(post);
        }

        [HttpPost]
        public IActionResult Update(PostViewModel viewModel)
        {
            postService.Update(viewModel);
            return RedirectToAction("GetPost" , new { id = viewModel.Id });
        }
    }
}