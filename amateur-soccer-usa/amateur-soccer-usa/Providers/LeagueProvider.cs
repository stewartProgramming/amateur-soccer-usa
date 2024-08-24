using AutoMapper;
using Entities.Database;
using Entities.DTO;
using Entities.Parameters;
using Repository.League;

namespace amateur_soccer_usa.Providers
{
    public class LeagueProvider(ILeagueRepository leagueRepo, IMapper mapper) : ILeagueProvider
    {
        public async Task<IEnumerable<LeagueDTO>> GetAsync(LeagueParameters parameters)
        {
            IEnumerable<League> leagues = await leagueRepo.GetAsync(parameters);

            return mapper.Map<IEnumerable<LeagueDTO>>(leagues);
        }
    }
}
