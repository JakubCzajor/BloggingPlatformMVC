using BloggingPlatform.Data;
using BloggingPlatform.Models;
using BloggingPlatform.Repository.IRepository;

namespace BloggingPlatform.Repository
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        private ApplicationDbContext _db;
        public PostRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
