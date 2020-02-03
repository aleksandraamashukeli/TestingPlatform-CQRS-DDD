using Services.Models.AnswerModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models.QuestionModels
{
    public class CreateQuestionModel
    {
        public string QuestionText { get; set; }
        public IEnumerable<CreateAnswerModel> Answers { get; set; }
    }
}
