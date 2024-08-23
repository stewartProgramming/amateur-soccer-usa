using Entities.Database;
using Entities.Parameters;
using Repository.League;

namespace amateur_soccer_usa.Providers
{
    public class LeagueProvider(ILeagueRepository leagueRepo) : ILeagueProvider
    {
        public async Task<IEnumerable<League>> GetAsync(LeagueParameters parameters)
        {
            return await leagueRepo.GetAsync(parameters);
        }
    }
}
