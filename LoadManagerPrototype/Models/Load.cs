using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Load
    {
        public int Id { get; set; }
        [Required]
        public int PONumber { get; set; }
        [Required]
        public decimal PayTruckRate { get; set; }
        [Required]
        public decimal CustomerBillRate { get; set; }

        public int CustomerId { get; set; } // FK to customer
        public virtual Customer Customer { get; set; }

        public int PickId { get; set; } //FK to pick up shed
        public virtual Shed PickShed { get; set; }

        public int DropId { get; set; } //FK to drop shed
        public virtual Shed DropShed { get; set; }

        public int CarrierId { get; set; } //FK to carrier
        public virtual Carrier Carrier { get; set; }

        public int UserId { get; set; } // FK to user
        public virtual User User { get; set; }

    }
    
}
