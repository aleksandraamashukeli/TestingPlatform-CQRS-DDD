using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models.TestModels
{
    public class DisplayTestModel
    {
        public int Id { get; set; }

        public int MaxScoreAvalaible { get; set; }

        public int PopularityScore { get; set; }

        public DateTime? AddedOn { get; set; }
        public string TestName { get; set; }
        public string TestDescription { get; set; }

        public string BackgroundImage { get; set; }

    }
}
