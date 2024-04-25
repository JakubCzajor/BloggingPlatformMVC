using BloggingPlatform.Data;
using BloggingPlatform.Models;
using BloggingPlatform.Repository.IRepository;

namespace BloggingPlatform.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
