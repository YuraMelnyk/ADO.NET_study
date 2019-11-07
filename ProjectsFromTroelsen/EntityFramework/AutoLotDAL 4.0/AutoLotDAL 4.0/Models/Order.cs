using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLotDAL_4._0.Models
{
    public partial class Order
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Required]
        public int CustId { get; set; }
        public int CarId { get; set; }
        [ForeignKey("CustId")]
        public virtual  Customer Customer { get; set; }
        [ForeignKey("CarId")]
        public virtual Inventory Car { get; set; }
    }
}
