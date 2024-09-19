using System.ComponentModel.DataAnnotations;

namespace Entities.DTO.League
{
    public class LeagueCreateDTO
    {
        [StringLength(150, ErrorMessage = "Cannot exceed 150 characters")]
        public required string Name { get; set; }
        public required int Region { get; set; }
        public required int Country { get; set; }
        public string? LogoUrl { get; set; }
        public int? Tier { get; set; }
        public int? StartingYear { get; set; }
    }
}
