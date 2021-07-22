using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class Dispatcher
    {
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Firstname { get; set; }
        [StringLength(30)]
        public string Lastname { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(12)]
        public string Fax { get; set; }
        public bool IsCckApproved { get; set; }
        public int CarrierId { get; set; }
        [JsonIgnore]
        public Carrier Carrier { get; set; }


        public Dispatcher()
        {

        }

    }
}
