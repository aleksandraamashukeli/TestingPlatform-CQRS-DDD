using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string TestName { get; set; }
        public string TestDescription { get; set; }
        public byte[] TestBackgroundImage { get; set; }

        public List<Question> Questions { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
