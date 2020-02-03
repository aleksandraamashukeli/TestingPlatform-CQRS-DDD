using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models.AnswerModels
{
    public class CreateAnswerModel
    {
        public bool IsCorrect { get; set; }

        public string AnswerText { get; set; }

    }
}
