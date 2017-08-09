using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wastelander.Models
{
    [Table("PlayerItems")]
    public class PlayerItems
    {
        [Key]
        public int Id { get; set; }
        public int PlayerId { get; set; }   
        public int ItemId { get; set; }
        public virtual Player Player { get; set; }
        public virtual Item Item { get; set; }
    }
}
