using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class CommodityDelivery
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CommodityId { get; set; }
        public virtual Commodity commodity { get; set; }

        [Required]
        public int DeliveryId { get; set; }
        public virtual Delivery delivery { get; set; }
    }
}
