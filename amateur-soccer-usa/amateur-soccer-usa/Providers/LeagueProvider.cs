using Entities.Database;
using Repository.League;

namespace amateur_soccer_usa.Providers
{
    public class LeagueProvider(ILeagueRepository leagueRepo) : ILeagueProvider
    {
        public async Task<IEnumerable<League>> GetAllLeaguesAsync()
        {
            return await leagueRepo.GetLeagues();
        }

        public async Task<IEnumerable<League>> GetLeaguesByAdministrativeRegionAsync
            (string administrativeRegion)
        {
            return await leagueRepo.GetLeaguesByAdministrativeRegion(administrativeRegion);
        }
    }
}
