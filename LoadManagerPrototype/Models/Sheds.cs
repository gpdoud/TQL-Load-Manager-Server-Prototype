using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Sheds
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Address { get; set; }

        // Instruction box?
    }
}
