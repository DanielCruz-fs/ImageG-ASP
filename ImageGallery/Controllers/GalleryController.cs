using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageGallery.Models;
using ImageGalleryData.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImagetags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Id = 0,
                Description = "Adventure"
            };
            var tag2 = new ImageTag()
            {
                Id = 0,
                Description = "Urban"
            };
            var tag3 = new ImageTag()
            {
                Id = 0,
                Description = "New York"
            };

            hikingImagetags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTag>{ tag2, tag3});
            var imageList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title = "Hiking Trip",
                    Url = "https://www.slovenia.info/imagine_cache/og/uploads/dozivetja/myway/myway-tiny/hiking_crna_prst_s.jpg",
                    Created = DateTime.Now,
                    Tags = hikingImagetags
                },
                new GalleryImage()
                {
                    Title = "On The Trail",
                    Url = "https://vmd.hr/eng/wp-content/uploads/hiking-400x400.jpg",
                    Created = DateTime.Now,
                    Tags = hikingImagetags
                },
                new GalleryImage()
                {
                    Title = "Downtown",
                    Url = "https://localfoodtours.com/wp-content/uploads/2018/06/Downtown-Toronto-East-Condos-final-400x400.jpg",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                }
            };

            var model = new GalleryIndexModel()
            {
                Images = imageList,
                searchQuery = ""
            };
            
            return View(model);
        }
    }
}