using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class User :IdentityUser
    {
        public string FirstName { get; set; }

        public string Score { get; set; }

        public string LastName { get; set; }

        public string ProfileImage { get; set; }

        public virtual List<Test> Tests { get; set; }
        
    }
}
