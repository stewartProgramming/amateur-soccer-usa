namespace Entities.DTO
{
    public class LeagueTeamDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? ShortName { get; set; }
        public string? TeamLogo { get; set; }
        public string? SmallTeamLogo { get; set; }
    }
}
