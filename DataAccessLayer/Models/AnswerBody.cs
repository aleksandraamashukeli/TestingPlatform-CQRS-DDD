using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class AnswerBody
    {
        public int Id { get; set; }
        public byte[] BackgroundImage { get; set; }
        public string AnswerText { get; set; }

        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
