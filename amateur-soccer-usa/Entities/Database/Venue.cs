using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Database
{
    [Table("Venues")]
    public class Venue
    {
        [Key]
        [Column("VenueId")]
        public int Id { get; set; }

        [Column("VenueName")]
        [Required(ErrorMessage = "Venue name is required")]
        [StringLength(255, ErrorMessage = "Cannot exceed 255 characters")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Venue settlement (city, town, etc.) is required")]
        [StringLength(255, ErrorMessage = "Cannot exceed 255 characters")]
        public required string Settlement { get; set; }

        [Column("VenueAddress")]
        [StringLength(255, ErrorMessage = "Cannot exceed 255 characters")]
        public string? Address { get; set; }

        [Column("VenueImage")]
        [StringLength(int.MaxValue, ErrorMessage = "Cannot exceed max characters")]
        public string? VenuePhoto { get; set; }

        [ForeignKey(nameof(Country))]
        public required int CountryId { get; set; }
        public required Country Country { get; set; }

        [ForeignKey(nameof(Region))]
        public required int RegionId { get; set; }
        public required Region Region { get; set; }
    }
}
