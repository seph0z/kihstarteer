using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Domain.Contracts;
using CourseProject.Domain.Contracts.ViewModels;
using CourseProject.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseProject.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetProfile (string id)
        {
            var user = userService.Get(id);
            var role1 = User.IsInRole("Admin");
           
            return View(user);
        }

        public IActionResult Profile(string id)
        {
            return PartialView();
        }

        public IActionResult SettingProfile(string id)
        {
            var user = userService.Get(id);
            var roles = userService.GetRoles();
            if(user.Role != null)
            {
                roles.ToList().Find(x => x.Value == user.Role).Selected = true;
            }
            ViewBag.Role = roles;
            return View(user);
        }

        [HttpPost]
        public IActionResult SettingProfile(UserViewModel viewModel)
        {
            userService.Update(viewModel);
            return RedirectToAction("GetProfile", new { id = viewModel.Id });
        }

        public IActionResult ProfileImage(List<IFormFile> formFiles)
        {
            var dbx = new DropboxWorker();
            dbx.Add(formFiles);
            var viewImages = dbx.GetPath(formFiles);
            return PartialView(viewImages);
        }

        public IActionResult UserCampaigns(string id)
        {
            var projects = userService.GetProjects(id);
            return View(projects);
        }

        public IActionResult UserManagement()
        {
            var users = userService.GetUsers();
            return View(users);
        }

        public IActionResult Remove(string id)
        {
            userService.Remove(id);
            return RedirectToAction("UserManagement");
        }

        public IActionResult MyRewards(string id)
        {
            //var rewards = userService.Get(id).Rewards;
            var rewards = userService.GetRewards(id);
            return View(rewards);
        }
    }
}