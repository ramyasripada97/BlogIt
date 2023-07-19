using BlogWallMicroService.DbContexts;
using BlogWallMicroService.Models;
using BlogWallMicroService.RepositoryInterface;
using BlogWallMicroService.ViewModels;

namespace BlogWallMicroService.Repostitory
{
    public class BlogWallRepository: IBlogWallRepository
    {
        private readonly ApplicationDbContext _context;

        public BlogWallRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public int InsertBlog(BlogWallViewModel model) 
        {
           _context.Add(model);
           return _context.SaveChanges(); 
        }

    }
}
