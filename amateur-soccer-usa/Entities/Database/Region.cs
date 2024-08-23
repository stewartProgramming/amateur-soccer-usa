using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Database
{
    [Table("Regions")]
    public class Region
    {
        [Key]
        [Column("RegionId")]
        public int RegionId { get; set; }

        [Column("RegionName")]
        [Required(ErrorMessage = "Region name is required")]
        [StringLength(255, ErrorMessage = "Cannot exceed 255 characters")]
        public required string Name { get; set; }

        [ForeignKey(nameof(Country))]
        [Required(ErrorMessage = "Country is required")]
        public required int CountryId { get; set; }
        public required Country Country { get; set; }
    }
}
