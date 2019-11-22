﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLotDAL_4._0.Models
{
    public partial class Customer
    {
        [Key]
        public int CustId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName => FirstName + " " + LastName;
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}