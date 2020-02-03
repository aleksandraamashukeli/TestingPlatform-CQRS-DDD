using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models.QuestionModels
{
    public class CreateQuestionBodyModel
    {
        public int Id { get; set; }
        public string BackgroundImage { get; set; }
        public string QuestionText { get; set; }

        public int QuestionId { get; set; }
    }
}
