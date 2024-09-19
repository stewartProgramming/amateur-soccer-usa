using Entities.Database;
using Entities.Parameters;
using Repository.Repository;

namespace Repository.Log
{
    public interface ILogRepository : IRepositoryBase<Entities.Database.Log>
    {
        Task<IEnumerable<Entities.Database.Log>> GetAsync(LogParameters parameters);
    }
}