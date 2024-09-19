using Entities.DTO.Log;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Database
{
    [Table("Logs")]
    public class Log
    {
        public Log() { }

        public Log(LogCreateDTO createModel)
        {
            Time = createModel.Time;
            UserId = createModel.UserId;
            Description = createModel.Description;
            Target = createModel.Target;
        }

        [Key]
        [Column("LogId")]
        public int LogId { get; set; }

        [Column("LogTime")]
        public required DateTime Time { get; set; }

        [ForeignKey(nameof(User))]
        public required int UserId { get; set; }
        public User? User { get; set; }

        [Column("LogDescription")]
        [StringLength(int.MaxValue, ErrorMessage = "Cannot exceed max characters")]
        public required string Description { get; set; }

        [Column("LogTarget")]
        [StringLength(150, ErrorMessage = "Cannot exceed 150 characters")]
        public required string Target { get; set; }
    }
}