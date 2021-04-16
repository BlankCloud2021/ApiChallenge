using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiChallenge
{
    public class Team
    {
        [Key]
        public short Id { get; set; }   

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }    

        [MaxLength(8)]
        public List<Player> Players { get; set; }
    }
}
