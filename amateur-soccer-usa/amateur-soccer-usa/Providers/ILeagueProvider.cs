using Entities.Database;
using Entities.Parameters;

namespace amateur_soccer_usa.Providers
{
    public interface ILeagueProvider
    {
        Task<IEnumerable<League>> GetAsync(LeagueParameters parameters);
    }
}
