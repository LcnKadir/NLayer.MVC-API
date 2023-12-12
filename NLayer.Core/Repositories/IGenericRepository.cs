using System.Linq.Expressions;

namespace NLayer.Core.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entites);
        void Update(T entitiy);
        void Remove(T entitiy);
        void RemoveRange(IEnumerable<T> entities);
    }
}
