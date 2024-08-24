using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Database
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        [Column("TeamId")]
        public int Id { get; set; }

        [Column("TeamName")]
        [Required(ErrorMessage = "Team name is required")]
        [StringLength(255, ErrorMessage = "Cannot exceed 255 characters")]
        public required string Name { get; set; }

        [StringLength(255, ErrorMessage = "Cannot exceed 255 characters")]
        public string? ShortName { get; set; }

        [Column("ImagePath")]
        [StringLength(int.MaxValue, ErrorMessage = "Cannot exceed max characters")]
        public string? TeamLogo { get; set; }

        [Column("SmallImagePath")]
        [StringLength(int.MaxValue, ErrorMessage = "Cannot exceed max characters")]
        public string? SmallTeamLogo { get; set; }

        [ForeignKey(nameof(Country))]
        [Required(ErrorMessage = "Team country is required")]
        public required int CountryId { get; set; }
        public required Country Country { get; set; }

        [ForeignKey(nameof(Region))]
        public int? RegionId { get; set; }
        public Region? Region { get; set; }

        [ForeignKey(nameof(League))]
        public int? LeagueId { get; set; }
        public League? League { get; set; }

        [ForeignKey(nameof(Venue))]
        public int? VenueId { get; set; }
        public Venue? Venue { get; set; }
    }
}
