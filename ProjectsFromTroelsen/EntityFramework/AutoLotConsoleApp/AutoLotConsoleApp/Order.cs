namespace AutoLotConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int OrderId { get; set; }

        public int CarID { get; set; }

        public int CustId { get; set; }

        public virtual Custumer Custumer { get; set; }

        public virtual Car Car { get; set; }
    }
}
