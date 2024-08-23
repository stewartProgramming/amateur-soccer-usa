using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Database
{
    [Table("League")]
    public class League
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(150, ErrorMessage = "Cannot exceed 150 characters")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [StringLength(100, ErrorMessage = "Cannot exceed 100 characters")]
        public required string Country { get; set; }

        [Required(ErrorMessage = "Administrative region is required")]
        [StringLength(100, ErrorMessage = "Cannot exceed 100 characters")]
        public required string AdministrativeRegion { get; set; }

        [Required(ErrorMessage = "Start year is required")]
        public required int StartYear { get; set; }
    }
}
