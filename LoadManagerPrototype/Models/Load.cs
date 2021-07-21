using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Load
    {
        public int Id { get; set; }
        [Required]
        public int PoNumber { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal PayTruckRate { get; set; }
        [Column(TypeName="decimal(9,2)")]
        public decimal CustomerBillRate { get; set; }

        public int CustomerId { get; set; } // FK to customer
        public virtual Customer Customer { get; set; }

        public virtual IEnumerable<Pickup> Pickups { get; set; }
        public virtual IEnumerable<Delivery> Deliveries { get; set; }

        public int CarrierId { get; set; } //FK to carrier
        public virtual Carrier Carrier { get; set; }
        
        public Load()
       {
         
       }
      


    }
    
}
