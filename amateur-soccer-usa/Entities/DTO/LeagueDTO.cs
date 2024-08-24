using Entities.Database;

namespace Entities.DTO
{
    public class LeagueDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int? StartingYear { get; set; }
        public required Region Region { get; set; }
        public string? Logo { get; set; }
        public IEnumerable<LeagueTeamDTO>? Teams { get; set; }
    }
}
