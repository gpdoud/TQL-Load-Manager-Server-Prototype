using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Load
    {
        public int Id { get; set; }
        public int PoNumber { get; set; }
        public Customer CustomerId { get; set; }
        public Shed PickShed { get; set; }
        public Shed DropShed { get; set; }
        public Carrier Carrier { get; set; }
        public User User { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal PayTruckRate { get; set; }
        [Column(TypeName="decimal(9,2)")]
        public decimal CustomerBillRate { get; set; }

    }
    
}
