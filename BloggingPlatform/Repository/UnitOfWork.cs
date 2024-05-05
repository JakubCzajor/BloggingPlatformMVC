using BloggingPlatform.Data;
using BloggingPlatform.Repository.IRepository;

namespace BloggingPlatform.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IPostRepository Post { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Post = new PostRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
