using Entities.Parameters;
using Repository.Repository;

namespace Repository.League
{
    public interface ILeagueRepository : IRepositoryBase<Entities.Database.League>
    {
        Task<Entities.Database.League?> FindAsync(int leagueId);
        Task<IEnumerable<Entities.Database.League>> GetAsync(LeagueParameters parameters);
    }
}
