using ImageGalleryData;
using ImageGalleryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ImageGalleryServices
{
    public class ImageService : IImage
    {
        private readonly ImageGalleryDbContext context;

        public ImageService(ImageGalleryDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<GalleryImage> GetAll()
        {
            return this.context.GalleryImages.Include(img => img.Tags);
        }

        public GalleryImage GetById(int id)
        {
            return this.GetAll().Where(img => img.Id == id).FirstOrDefault();
        }

        public IEnumerable<GalleryImage> GetWithTag(string tag)
        {
            return this.GetAll().Where(img => img.Tags.Any(t => t.Description == tag));
        }
    }
}
