using BloggingPlatform.Models;

namespace BloggingPlatform.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
