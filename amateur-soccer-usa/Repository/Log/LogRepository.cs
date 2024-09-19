using Entities.Database;
using Entities.Parameters;
using Microsoft.EntityFrameworkCore;
using Repository.Repository;

namespace Repository.Log
{
    public class LogRepository(RepositoryContext repoContext)
        : RepositoryBase<Entities.Database.Log>(repoContext), ILogRepository
    {
        public async Task<IEnumerable<Entities.Database.Log>> GetAsync(LogParameters parameters)
        {
            IQueryable<Entities.Database.Log> logs = FindAll();

            if (parameters.UserId != null)
            {
                logs = logs.Where(x => x.UserId.Equals(parameters.UserId));
            }

            if (!string.IsNullOrEmpty(parameters.LogTarget))
            {
                logs = logs.Where(x => x.Target.Equals(parameters.LogTarget));
            }

            return await logs.ToListAsync();
        }
    }
}