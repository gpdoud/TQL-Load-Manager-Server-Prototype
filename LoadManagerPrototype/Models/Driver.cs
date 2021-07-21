using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Driver
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Firstname { get; set; }
        [StringLength(30)]
        public string Lastname { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(20)]
        public string TruckNumber {get; set; }
        [StringLength(20)]
        public string TrailerNumber { get; set; }
        public string Equipment { get; set; }
        public bool IsCckApproved { get; set; }

        public Driver()
        {

        }
    }
}