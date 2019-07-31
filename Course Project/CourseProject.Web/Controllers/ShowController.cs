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
        private readonly IUserService userService;
        public ShowController(
            IShowProjectService showProjectService,
            IPostService postService,
            IUserService userService
            )
        {
            this.showProjectService = showProjectService;
            this.postService = postService;
            this.userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get(int Id)
        {
            var project = showProjectService.Get(Id);
            ViewBag.Percent = (int)((project.CurrentFunding * 100) / project.Funding);
            project.Content = Markdown.ToHtml(project.Content);
            ViewBag.UserImage = userService.Get(User.FindFirstValue(ClaimTypes.NameIdentifier)).Image;
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
            post.Content = Markdown.ToHtml(post.Content);
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

        public IActionResult Dotate(double count, int projectId, double funding , int rewardId)
        {
            if(rewardId != 0)
            {
                userService.AddReward(rewardId, User.FindFirstValue(ClaimTypes.NameIdentifier));
            }
            var currentCoutn = showProjectService.AddMoney(count, projectId);
            ViewBag.CurrentFunding = currentCoutn;
            ViewBag.Percent = (int)((currentCoutn * 100) / funding);
            return PartialView();           
        }
    }
}