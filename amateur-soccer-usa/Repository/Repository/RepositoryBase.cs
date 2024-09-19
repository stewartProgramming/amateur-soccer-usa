using Entities.Database;
using System.Linq.Expressions;

namespace Repository.Repository
{
    public abstract class RepositoryBase<T>(RepositoryContext repoContext) 
        : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; } = repoContext;

        public IQueryable<T> FindAll()
        {
            return RepositoryContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return RepositoryContext.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public async Task<int> SaveAsync()
        {
            return await RepositoryContext.SaveChangesAsync();
        }


        public async Task<int> CreateAndSaveAsync(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);

            return await RepositoryContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAndSaveAsync(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);

            return await RepositoryContext.SaveChangesAsync();
        }
    }
}
