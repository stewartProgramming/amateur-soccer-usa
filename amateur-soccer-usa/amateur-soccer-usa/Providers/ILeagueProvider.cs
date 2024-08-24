using Entities.DTO;
using Entities.Parameters;

namespace amateur_soccer_usa.Providers
{
    public interface ILeagueProvider
    {
        Task<IEnumerable<LeagueDTO>> GetAsync(LeagueParameters parameters);
    }
}
