using ImageUploaderAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImageUploaderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly ImageDbContext _dbContext;

        public ImageController(ImageDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult PostImage (IFormFile file)
        {
            if (file == null || file.Length <= 0)
            {
                return BadRequest("No file was received.");
            }

            return Ok(file);
            //

        }
    }
}