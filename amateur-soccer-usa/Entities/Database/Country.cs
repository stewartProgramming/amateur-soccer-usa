using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Database
{
    [Table("Countries")]
    public class Country
    {
        [Key]
        [Column("CountryId")]
        public int Id { get; set; }

        [Column("CountryName")]
        [Required(ErrorMessage = "Country name is required")]
        [StringLength(255, ErrorMessage = "Cannot exceed 255 characters")]
        public required string Name { get; set; }

        [Column("CountryAbv")]
        [StringLength(25, ErrorMessage = "Cannot exceed 25 characters")]
        public string? Abbreviation { get; set; }
    }
}
