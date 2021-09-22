using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationUI.Models.TestModels
{
    public class SubmitTestViewModel
    {
        public int TestId { get; set; }

        public IEnumerable<FinishedQuestion> FinishedQuestions { get; set; }
    }

    public class FinishedQuestion
    {
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
    }
}
