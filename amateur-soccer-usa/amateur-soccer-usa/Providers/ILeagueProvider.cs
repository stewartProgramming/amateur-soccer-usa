using Entities.Database;

namespace amateur_soccer_usa.Providers
{
    public interface ILeagueProvider
    {
        Task<IEnumerable<League>> GetAllLeaguesAsync();
        Task<IEnumerable<League>> GetLeaguesByAdministrativeRegionAsync(string administrativeRegion);
    }
}
