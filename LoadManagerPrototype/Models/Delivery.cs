using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public DateTime DropDate { get; set; }
        public bool OnSite { get; set; }
        public bool Unloaded { get; set; }

        public int ShedId { get; set; }
        public virtual Shed shed { get; set; }

        public virtual IEnumerable<CommodityDelivery> CommodityDeliveries { get; set; }

        public Delivery()
        {

        }
    }
}
