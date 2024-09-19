using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Database
{
    [Table("Users")]
    public class User
    {
        [Column("UserId")]
        public required int Id { get; set; }

        [StringLength(255, ErrorMessage = "Username cannot exceed 255 characters")]
        public required string Username { get; set; }

        [EmailAddress(ErrorMessage = "Invalid e-mail format")]
        [StringLength(255, ErrorMessage = "Email cannot exceed 255 characters")]
        public required string Email { get; set; }
    }
}