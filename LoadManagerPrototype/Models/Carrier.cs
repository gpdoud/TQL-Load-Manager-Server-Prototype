using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Carrier
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Address { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(10)]
        public string Zip { get; set; }
        [StringLength(30)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(8)]
        public string McNumber { get; set; }

        public virtual IEnumerable<Driver> Drivers { get; set; }
        public virtual IEnumerable<Dispatcher> Dispatchers { get; set; }

        public Carrier()
        {

        }


    }
}
