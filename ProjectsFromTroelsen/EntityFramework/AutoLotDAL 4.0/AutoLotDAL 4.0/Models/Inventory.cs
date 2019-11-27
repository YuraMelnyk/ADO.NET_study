using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AutoLotDAL_4._0.Models
{
    [Table("Inventory")]
    public partial class Inventory
    {
        [Key]
        public int CarId { get; set; }
        [StringLength(50)]
        public string Make { get; set; }
        [StringLength(50)]
        public string Color { get; set; }
        [StringLength(50)]
        public string PetName { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        public override string ToString()
        {
            return $"{this.PetName ?? "**NoName**"} is a {this.Color} {this.Make} with ID {this.CarId}";
        }

        [NotMapped]
        public string MakeColor => $"{Make}+{Color}";
    }
}
