using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public sealed class CategoryEventRepository(RepositoryDbContext dbContext)
     : BaseRepository<CategoryEvents>(dbContext), ICategoryEventRepository
    {
        public async Task<CategoryEvents?> GetBySlugAsync(string slug)
        {
            return await _dbSet.FirstOrDefaultAsync(c => c.Slug == slug);
        }

        public bool IsNameDuplicate(string name)
        {
            return _dbSet.Any(c => c.Name == name);
        }

        public bool IsCategoryInUse(int id)
        {
            return _dbSet.Any(c => c.Id == id && (c.Events != null && c.Events.Count() != 0));
        }

        public bool HasSlug(string slug)
        {
            return _dbSet.Any(c => c.Slug == slug);
        }
    }
}
