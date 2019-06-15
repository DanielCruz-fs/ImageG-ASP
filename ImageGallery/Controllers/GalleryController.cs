using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageGallery.Models;
using ImageGalleryData;
using ImageGalleryData.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IImage imageService;

        public GalleryController(IImage imageService)
        {
            this.imageService = imageService;
        }
        public IActionResult Index()
        {
            var imageList = this.imageService.GetAll();
            var model = new GalleryIndexModel()
            {
                Images = imageList,
                searchQuery = ""
            };
            
            return View(model);
        }
    }
}