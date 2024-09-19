using Entities.DTO.League;
using Entities.Parameters;

namespace amateur_soccer_usa.Providers
{
    public interface ILeagueProvider
    {
        Task<string> CreateAsync(LeagueCreateDTO createModel);
        Task<IEnumerable<LeagueDTO>> GetAsync(LeagueParameters parameters);
        Task UpdateAsync(LeagueUpdateDTO updateModel);
        Task<string> DeleteAsync(int leagueId);
    }
}