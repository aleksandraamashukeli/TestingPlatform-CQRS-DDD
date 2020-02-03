using Services.Models.QuestionModels;
using System;
using System.Collections.Generic;

namespace Services.Models.TestModels
{
    public class CreateTestModel
    {
        public string UserId { get; set; }

        public string TestName { get; set; }

        public string TestDescription { get; set; }

        public int PopularityScore { get; set; }

        public DateTime? AddedOn { get; set; }

        public int MaxScoreAvalaible { get; set; }

        public IEnumerable<CreateQuestionModel> Questions { get; set; }

        public string BackgroundImage { get; set; }

    }
}
