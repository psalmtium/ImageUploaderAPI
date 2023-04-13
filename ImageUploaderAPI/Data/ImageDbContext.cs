using ImageUploaderAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ImageUploaderAPI.Data
{
    public class ImageDbContext : DbContext
    {
        public ImageDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Image> Images { get; set; }

       
    }

}
