using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Database
{
    [Table("Leagues")]
    public class League
    {
        [Key]
        [Column("LeagueId")]
        public int Id { get; set; }

        [Column("LeagueName")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(150, ErrorMessage = "Cannot exceed 255 characters")]
        public required string Name { get; set; }

        [Column("StartYear")]
        public int? StartingYear { get; set; }

        //[ForeignKey(nameof(Country))]
        //[Required(ErrorMessage = "Country is required")]
        //public required int CountryId { get; set; }
        //public required Country Country { get; set; }

        [ForeignKey(nameof(Region))]
        [Required(ErrorMessage = "Region is required")]
        public required int RegionId { get; set; }
        public required Region Region { get; set; }

        [Required(ErrorMessage = "Active is required")]
        public required bool Active { get; set; }

        [Column("LeagueLogo")]
        [StringLength(500, ErrorMessage = "Cannot exceed 500 characters")]
        public string? Logo { get; set; }
    }
}
