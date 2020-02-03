using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models.UserModels
{
    public class SignInUserModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
