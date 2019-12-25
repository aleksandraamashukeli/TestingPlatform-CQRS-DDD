using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class QuestionBody :Entity
    {
        public string BackgroundImage { get; set; }
        public string QuestionText { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
