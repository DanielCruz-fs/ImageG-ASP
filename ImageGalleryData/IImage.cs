using ImageGalleryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageGalleryData
{
    public interface IImage
    {
        IEnumerable<GalleryImage> GetAll();
        IEnumerable<GalleryImage> GetWithTag(string tag);
        GalleryImage GetById(int id);
    }
}
