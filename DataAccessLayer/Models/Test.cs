using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Test :Entity
    {
        public string TestName { get; set; }

        public int MaxScoreAvalaible { get; set; }

        public int PopularityScore { get; set; }

        public DateTime? AddedOn { get; set; }

        public string TestDescription { get; set; }

        public string BackgroundImage { get; set; }

        public virtual List<Question> Questions { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
