using Entities.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
    }
}
