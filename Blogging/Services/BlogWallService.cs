using BlogWallMicroService.IService;
using BlogWallMicroService.Models;
using BlogWallMicroService.RepositoryInterface;
using BlogWallMicroService.ViewModels;
using Microsoft.AspNetCore.Components.Forms;

namespace BlogWallMicroService.Services
{
    public class BlogWallService: IBlogWallService
    {
        private readonly IBlogWallRepository _blogWallRepository;

        public BlogWallService(IBlogWallRepository blogWallRepository)
        {
            _blogWallRepository = blogWallRepository;
        }

        public int AddBlogService(BlogWallViewModel blogWall)
        {
            BlogWallViewModel blogWallModel = new BlogWallViewModel()
            {
                Id = Guid.NewGuid(),
                Description = blogWall.Description,
                DescImage = ImageConversion(blogWall.Image),
                DateCreated = DateTime.Now,
                DateUpdated = null
            };
            var result = _blogWallRepository.InsertBlog(blogWallModel);
            return result;
        }

        private byte[] ImageConversion(IFormFile file)
        {
            byte[] ImageByteArray;
            using(var stream = new MemoryStream()) 
            {
                file.CopyTo(stream);
                ImageByteArray = stream.ToArray();
            }
            return ImageByteArray;
        }
    }
}
