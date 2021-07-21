using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Commodity
    {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required, StringLength(255)]
        public string Unit { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
    }
}
