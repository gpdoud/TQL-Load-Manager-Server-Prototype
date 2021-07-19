using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Load
    {
        public int Id { get; set; }
        public int PONumber { get; set; }
        public Customer Customer { get; set; }
        public Shed PickShed { get; set; }
        public Shed DropShed { get; set; }
        public Carrier Carrier { get; set; }
        public User User { get; set; }
        public decimal PayTruckRate { get; set; }
        public decimal CustomerBillRate { get; set; }

    }
    
}
