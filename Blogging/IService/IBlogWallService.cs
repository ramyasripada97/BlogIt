using BlogWallMicroService.Models;
using BlogWallMicroService.ViewModels;

namespace BlogWallMicroService.IService
{
    public interface IBlogWallService
    {
        int AddBlogService(BlogWallViewModel blogWall);
    }
}
