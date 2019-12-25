﻿using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class User : Entity
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ProfileImage { get; set; }

        public List<Test> Tests { get; set; }

    }
}
