using Entities.Parameters;
using Repository.Repository;

namespace Repository.League
{
    public interface ILeagueRepository : IRepositoryBase<Entities.Database.League>
    {
        Task<IEnumerable<Entities.Database.League>> GetAsync(LeagueParameters parameters);
    }
}
