using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public DateTime DropDate { get; set; }
        public bool OnSite { get; set; }
        public bool Unloaded { get; set; }

        public virtual IEnumerable<Shed> Sheds { get; set; }
        public virtual IEnumerable<Commodity> Commodities { get; set; }
    }
}
