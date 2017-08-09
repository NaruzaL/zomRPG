using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wastelander.Models
{
    [Table("Players")]
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Name { get; set; }

        public int Endurance { get; set; }
        public int Attack { get; set; }
        public int Luck { get; set;  }
        public int Expierience { get; set; }
        public int LocationId { get; set; }
        public virtual Location currentLocation { get; set; }
        public virtual ICollection<PlayerItems> Items { get; set; }
    }
}
