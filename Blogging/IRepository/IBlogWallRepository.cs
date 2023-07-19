using BlogWallMicroService.Models;
using BlogWallMicroService.ViewModels;

namespace BlogWallMicroService.RepositoryInterface
{
    public interface IBlogWallRepository
    {
        int InsertBlog(BlogWallViewModel model);

    }
}
