using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wastelander.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Rarity { get; set; }
        public bool AttackEffect { get; set; }
        public bool EnduranceEffect { get; set; }
        public bool LuckEffect { get; set; }
        public bool HealsPlayer { get; set; }
        public virtual ICollection<PlayerItems> Players { get; set; }

    }
}
