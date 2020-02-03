using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Question :Entity
    {
        public int CorrectAnswerScore { get; set; }
        public string BackgroundImage { get; set; }
        public string QuestionText { get; set; }
        public virtual List<Answer> Answers { get; set; }

        public int TestId { get; set; }
        public virtual Test Test { get; set; }

    }
}
