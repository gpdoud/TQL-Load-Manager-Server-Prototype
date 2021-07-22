using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Pickup
    {
        public int Id { get; set; }
        public DateTime PickDate { get; set; }
        public bool OnSite { get; set; }
        public bool Loaded { get; set; }

        public int ShedId { get; set; }
        public virtual Shed shed { get; set; }

        public virtual IEnumerable<CommodityPickup> CommodityPickups { get; set; }

        public Pickup()
        {

        }

    }
}
