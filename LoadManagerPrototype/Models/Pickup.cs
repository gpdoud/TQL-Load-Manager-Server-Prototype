using System;
using System.Collections.Generic;
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

        public virtual IEnumerable<Shed> Sheds { get; set; }
        public virtual IEnumerable<Commodity> Commodities { get; set; }

    }
}
