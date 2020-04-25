using Microsoft.AspNetCore.Mvc;
using IntroVisual.Models;
using IntroVisual.ViewModels;
using System.Linq;
using IntroVisual.Services;
using IntroVisual.Entities;
using System;

namespace IntroVisual.Controllers
{
    //[Route("company/[controller]/[action]")]
    public class HomeController : Controller
    {

        private IVideoData _videos;

        public HomeController(IVideoData videos)
        {
            _videos = videos;
        }
        public ViewResult Index()
        {
            var model = _videos.GetAll().Select(Video =>
            new VideoViewModel
            {
                Id = Video.Id,
                Title = Video.Title,
                Genre = Enum.GetName(typeof(Genres), Video.GenreId)
                

              
            });
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _videos.Get(id);

            if (model == null) return RedirectToAction("Index");

            return View(new VideoViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Genre = Enum.GetName(typeof(Genres), model.GenreId)

            }); ;

        }
    }
}

