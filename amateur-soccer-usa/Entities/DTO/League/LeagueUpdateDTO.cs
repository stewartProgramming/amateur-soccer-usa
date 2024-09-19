namespace Entities.DTO.League
{
    public class LeagueUpdateDTO
    {
        public required int LeagueId { get; set; }
        public string? LeagueName { get; set; }
        public int? RegionId { get; set; }
        public int? CountryId { get; set; }
        public string? LogoUrl { get; set; }
        public int? Tier { get; set; }
        public int? StartYear { get; set; }
    }
}
