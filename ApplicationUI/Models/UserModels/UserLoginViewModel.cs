using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationUI.Models.UserModels
{
    public class UserLoginViewModel : BaseUserModel
    {
        public bool RememberMe { get; set; }
    }
}
