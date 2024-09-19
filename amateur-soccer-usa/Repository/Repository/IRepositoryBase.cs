using System.Linq.Expressions;

namespace Repository.Repository
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<int> SaveAsync();

        Task<int> CreateAndSaveAsync(T entity);
        Task<int> DeleteAndSaveAsync(T entity);
    }
}
