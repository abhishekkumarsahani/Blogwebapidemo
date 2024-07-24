using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service;
using Service.Interface;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]"), EnableCors("CorsPolicy")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost, Route("~/api/admin/blog_category")]
        public async Task<IActionResult> BlogCategory(BlogCategory category)
        {
            var data = await _unitOfWork.blogservice.BlogCategory(category);
            return Ok(data);
        }

        [HttpPost, Route("~/api/admin/blog-tags")]
        public async Task<IActionResult> BlogTags(BlogTags tags)
        {
            var data = await _unitOfWork.blogservice.BlogTags(tags);
            return Ok(data);
        }

        [HttpPost, Route("~/api/admin/blog-posts")]
        public async Task<IActionResult> BlogPost(BlogPost post)
        {
            var data = await _unitOfWork.blogservice.BlogPost(post);
            return Ok(data);
        }


        [HttpPost, Route("~/api/admin/posts-tags")]
        public async Task<IActionResult> BlogPostTags(PostTag blogTags)
        {
            var data = await _unitOfWork.blogservice.BlogPostTags(blogTags);
            return Ok(data);
        }


        [HttpPost, Route("~/api/admin/bus")]
        public async Task<IActionResult> CreateBus(Bus bus)
        {
            var data = await _unitOfWork.blogservice.Bus(bus);
            return Ok(data);
        }


        [HttpPost, Route("~/api/admin/assign_bus")]
        public async Task<IActionResult> AssignBus(AssignBus assignBus)
        {
            var data = await _unitOfWork.blogservice.AssignBus(assignBus);
            return Ok(data);
        }



    }
}
