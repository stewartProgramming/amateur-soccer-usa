using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO.League
{
    public class LeagueCreateDTO
    {
        [StringLength(150, ErrorMessage = "Cannot exceed 150 characters")]
        public required string Name { get; set; }

        [StringLength(200, ErrorMessage = "Cannot exceed 200 characters")]
        public required string Country { get; set; }
        
        
        public int? Tier { get; set; }
        public int? StartingYear { get; set; }
    }
}
