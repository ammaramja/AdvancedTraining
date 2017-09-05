using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationsNauthenNauthoNdatabase.Models
{
    public class LoginSubmit
    {
        [Required(ErrorMessage = "UserName required")]
        public String userName { get; set; }
        [Required]
        public String password { get; set; }
    }
}