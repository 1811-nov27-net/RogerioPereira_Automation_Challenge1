using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Users.Models
{
    public class User
    {
        [Required]
        [StringLength(30)]
        public String FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public String LastName { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        public String Phone { get; set; }

        [Required]
        [StringLength(100)]
        public String Address { get; set; }

        [Required]
        [StringLength(50)]
        public String Company { get; set; }

        [Required]
        [StringLength(30)]
        public String Role { get; set; }
    }
}
