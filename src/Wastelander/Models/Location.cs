using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wastelander.Models
{
    [Table("Locations")]
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string Name { get; set; }
        public int SpawnEnemy {  get; set; }
        public string Description { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
