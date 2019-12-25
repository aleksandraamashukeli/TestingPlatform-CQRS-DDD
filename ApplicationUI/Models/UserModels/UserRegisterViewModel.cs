using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationUI.Models.UserModels
{
    public class UserRegisterViewModel : BaseUserModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }

        public IFormFile ProfileImage { get; set; }

        
    }
}
