using ImageGalleryData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ImageGalleryData
{
    public class ImageGalleryDbContext : DbContext
    {
        public ImageGalleryDbContext(DbContextOptions options) : base(options) { }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }
    }
}
