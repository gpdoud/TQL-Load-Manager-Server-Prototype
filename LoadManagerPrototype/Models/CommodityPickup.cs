using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class CommodityPickup
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CommodityId { get; set; }
        public virtual Commodity commodity { get; set; }

        [Required]
        public int PickupId { get; set; }
        public virtual Pickup pickup { get; set; }
    }
}
