using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wastelander.Models
{
    [Table("Zombies")]
    public class Zombie
    {
        [Key]
        public int ZombieId { get; set; }
        public string Name { get; set; }
        public int ZombieAttack { get; set; }
        public int ZombieHealth { get; set; }
        public int ChanceToDrop { get; set; }
        public int ExperienceValue { get; set; }
    }
}
