using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EPlatform.WebUI.Models.User
{
    public class RegisterModel
    {
        [Required]
        public string UserFirstName { get; set; }

        [Required]
        public string UserLastName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }


    }
}
