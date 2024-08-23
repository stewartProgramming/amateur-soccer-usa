using Repository.Repository;

namespace Repository.League
{
    public interface ILeagueRepository : IRepositoryBase<Entities.Database.League>
    {
        Task<IEnumerable<Entities.Database.League>> GetLeagues();
        Task<IEnumerable<Entities.Database.League>> GetLeaguesByAdministrativeRegion
            (string administrativeRegion);
    }
}
