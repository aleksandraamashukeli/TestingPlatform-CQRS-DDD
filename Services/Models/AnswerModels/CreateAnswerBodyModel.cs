using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models.AnswerModels
{
    public class CreateAnswerBodyModel
    {
        public int Id { get; set; }
        public string BackgroundImage { get; set; }
        public string AnswerText { get; set; }
        public int AnswerId { get; set; }
    }
}
