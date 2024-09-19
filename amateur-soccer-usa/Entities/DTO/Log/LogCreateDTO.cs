using System.ComponentModel.DataAnnotations;

namespace Entities.DTO.Log
{
    public class LogCreateDTO
    {
        public required DateTime Time { get; set; }
        public required int UserId { get; set; }

        [StringLength(int.MaxValue, ErrorMessage = "Cannot exceed max characters")]
        public required string Description { get; set; }

        [StringLength(150, ErrorMessage = "Cannot exceed 150 characters")]
        public required string Target { get; set; }
    }
}
