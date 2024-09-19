using Entities.Database;
using Entities.Parameters;
using Microsoft.EntityFrameworkCore;
using Repository.Repository;

namespace Repository.League
{
    public class LeagueRepository(RepositoryContext repoContext) 
        : RepositoryBase<Entities.Database.League>(repoContext), ILeagueRepository
    {
        public async Task<Entities.Database.League?> FindAsync(int leagueId)
        {
            return await FindByCondition(x => x.Id == leagueId)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Entities.Database.League>> GetAsync(LeagueParameters parameters)
        {
            var leagues = FindAll();

            if (parameters.StartingYear != null)
                leagues = leagues
                    .Where(x => x.StartingYear == parameters.StartingYear);

            if (parameters.LeagueId != null)
                leagues = leagues
                    .Where(x => x.Id.Equals(parameters.LeagueId));

            if (parameters.RegionId != null)
                leagues = leagues
                    .Where(x => x.RegionId.Equals(parameters.RegionId));

            if (parameters.CountryId != null)
                leagues = leagues
                    .Where(x => x.Region != null && x.Region.CountryId.Equals(parameters.CountryId));

            return await leagues
                .Include(x => x.Region)
                    .ThenInclude(x => x.Country)
                .Include(x => x.Teams)
                .ToListAsync();
        }
    }
}
