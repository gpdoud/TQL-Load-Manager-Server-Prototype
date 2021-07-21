using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoadManagerPrototype.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Username { get; set; }     //needs to be unique
        [Required, StringLength(30)]
        public string Password { get; set; }
        [StringLength(30)]
        public string Firstname { get; set; }
        [StringLength(30)]
        public string Lastname { get; set; }
        [StringLength(100)]
        public string Email { get; set; }

    }
}
