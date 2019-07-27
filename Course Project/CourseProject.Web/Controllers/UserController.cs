using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IProfileService profileService;
        public UserController(IProfileService profileService)
        {
            this.profileService = profileService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetProfile (string id)
        {
            var user = profileService.Get(id);
            if(user == null)
                return View();
            return View(user);
        }

        public IActionResult Profile(string id)
        {
            return PartialView();
        }

    }
}