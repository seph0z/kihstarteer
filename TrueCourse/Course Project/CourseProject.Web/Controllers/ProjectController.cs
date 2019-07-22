using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CourseProject.Domain.Contracts;
using CourseProject.Domain.Contracts.ViewModels;
using CourseProject.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseProject.Web.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService projectService;
        private readonly IContentService contentService;
        private readonly ICategoryService categoryService;
        private readonly IImageService imageService;
        public ProjectController(
            IProjectService projectService, 
            IContentService contentService,
            ICategoryService categoryService,
            IImageService imageService)
        {
            this.projectService = projectService;
            this.contentService = contentService;
            this.categoryService = categoryService;
            this.imageService = imageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(int? id)
        {
            var catSel = categoryService.GetAll();
            ViewBag.Categories = catSel;
            if (id == null)
            {
                return View();
            }

            var project = projectService.Get((int)id);
            catSel.ToList().Find(x => x.Value == project.CategoryId.ToString()).Selected = true;
            ViewBag.Categories = catSel;
            return View(project);
        }

        [HttpPost]
        public IActionResult Create(ProjectViewModel viewModel)
        {
            int projectId;
            if (viewModel.Id == 0)
            {
                viewModel.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                projectId = projectService.Add(viewModel);
            }
            else
            {
                projectId = projectService.Update(viewModel);
            }
            return RedirectToAction("CreateMenu", new { id = projectId });
        }

        public IActionResult PreViewImage(List<IFormFile> formFiles)
        {
            var dbx = new DropboxWorker();
            dbx.Add(formFiles);
            var viewImages = dbx.GetPath(formFiles);
            return PartialView(viewImages);
        }

        public IActionResult CreateMenu(int id)
        {
            var categoryId = projectService.Get(id).CategoryId;
            ViewBag.Category = categoryService.GetAll().ToList().Find(x => x.Value == categoryId.ToString()).Text;

            return View(id);
        }

        [Route("Project/CreateContent/{projectId:int}")]
        [HttpGet]
        public IActionResult CreateContent(int projectId)
        {
            var content = contentService.Get(projectId);
            if (content == null)
            {
                content = new ContentViewModel { ProjectId = projectId };
            }
            return View(content);
        }

        [HttpPost]
        public IActionResult CreateContent(ContentViewModel viewModel)
        {
            int projectId;
            if (viewModel.Id == 0)
                projectId = contentService.Add(viewModel);
            else
                projectId = contentService.Update(viewModel);
            return RedirectToAction("CreateMenu", new { id = projectId });
        }

        public IActionResult PreViewImages(List<IFormFile> formFiles)
        {
            var dbx = new DropboxWorker();
            dbx.Add(formFiles);
            var viewImages = dbx.GetPath(formFiles);
            return PartialView(viewImages);
        }

        [HttpGet]
        [Route("Project/CreateAlbum/{projectId:int}")]
        public IActionResult CreateAlbum(int projectId)
        {
            ViewBag.Id = projectId;
            List<string> viewModels = imageService.GetAllList(projectId).ToList();
            if (viewModels.Count == 0)
                return View();         
            return View(viewModels);
        }

        [HttpPost]
        public IActionResult CreateAlbum(ImageViewModel viewModel)
        {
            return View();
        }

        public IActionResult PreViewAlbum(int id, List<IFormFile> formFiles)
        {
            var dbx = new DropboxWorker();
            dbx.Add(formFiles);
            var imageAlbum = dbx.GetPath(formFiles);
            imageService.UpdateList(imageAlbum, id);

            return PartialView(imageAlbum);
        }

    }
}