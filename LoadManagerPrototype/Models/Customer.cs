using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        [Required, StringLength(30)]
        public string Code { get; set; }            //needs to be UNIQUE
        [StringLength(30)]
        public string Address { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(10)]
        public string Zip { get; set; }
        [Required]
        public bool Status { get; set; }

        public int UserId { get; set; }       

        public virtual User User { get; set; }

        public Customer()
        {

        }
    }
}
