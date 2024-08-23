using Entities.Database;
using Microsoft.EntityFrameworkCore;
using Repository.Repository;

namespace Repository.League
{
    public class LeagueRepository(RepositoryContext repoContext) 
        : RepositoryBase<Entities.Database.League>(repoContext), ILeagueRepository
    {
        public async Task<IEnumerable<Entities.Database.League>> GetLeagues()
        {
            return await 
                FindAll()
                .ToListAsync();
        }

        public async Task<IEnumerable<Entities.Database.League>> GetLeaguesByAdministrativeRegion
            (string administrativeRegion)
        {
            return await 
                FindByCondition(x => x.AdministrativeRegion == administrativeRegion)
                .ToListAsync();
        }
    }
}
