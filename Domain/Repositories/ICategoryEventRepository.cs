using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICategoryEventRepository : IBaseRepository<CategoryEvents>
    {
        // Thêm các phương thức đặc thù cho CategoryEvents nếu cần
        Task<CategoryEvents?> GetBySlugAsync(string slug);
        bool GetByName(string name);
        bool IsCategoryInUse(int id);
    }
}