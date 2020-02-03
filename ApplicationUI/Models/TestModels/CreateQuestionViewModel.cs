using System.Collections.Generic;

namespace ApplicationUI.Models.TestModels
{
    public class CreateQuestionViewModel
    {
        public string QuestionText { get; set; }

        public int CorrectAnswerScore { get; set; }

        public string BackgroundImage { get; set; }
        public IEnumerable<CreateAnswerViewModel> Answers { get; set; }
    }
}