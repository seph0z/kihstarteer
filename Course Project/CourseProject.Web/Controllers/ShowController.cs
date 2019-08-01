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
            var projects = showProjectService.GetAll();
            return View(projects);
        }

        public IActionResult Find(string text)
        {
            var forFind = showProjectService.GetForFind(text);
            return View(forFind);
        }

        public IActionResult Get(int Id)
        {
            var project = showProjectService.Get(Id);
            ViewBag.Percent = (int)((project.CurrentFunding * 100) / project.Funding);
            if(project.Content != null)
                project.Content = Markdown.ToHtml(project.Content);
            var user = userService.Get(User.FindFirstValue(ClaimTypes.NameIdentifier));
            ViewBag.UserImage = "";
            if (user != null)
                ViewBag.UserImage = user.Image;
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
            ViewBag.Have = false;
            ViewBag.CurrentFunding = new double();
            ViewBag.Percent = new int();
            var currentCoutn = new double();
            var rew = userService.GetRewards(User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList().Find(x => x.Id == rewardId);

            if (rewardId != 0)
            {
                if(rew == null)
                {
                    userService.AddReward(rewardId, User.FindFirstValue(ClaimTypes.NameIdentifier));
                    currentCoutn = showProjectService.AddMoney(count, projectId);
                    ViewBag.Have = true;
                }
                else
                {
                    count = 0;
                    currentCoutn = showProjectService.AddMoney(count, projectId);
                }
            }
            else
            {
                currentCoutn = showProjectService.AddMoney(count, projectId);
                ViewBag.Have = true;
            }
            ViewBag.CurrentFunding = currentCoutn;
            ViewBag.Percent = (int)((currentCoutn * 100) / funding);
            return PartialView();           
        }
    }
}