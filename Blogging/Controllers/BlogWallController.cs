using BlogWallMicroService.IService;
using BlogWallMicroService.Models;
using BlogWallMicroService.RepositoryInterface;
using BlogWallMicroService.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BlogWallMicroService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogWallController : Controller
    {
       private readonly IBlogWallService _blogWallService;

       public BlogWallController(IBlogWallService blogWallService)
        {
            _blogWallService = blogWallService;
        }

        [HttpPost]
        public int AddBlog([FromForm] BlogWallViewModel blogWall)
        {
            var Result = _blogWallService.AddBlogService(blogWall);
            return Result;
        }
    }
}
