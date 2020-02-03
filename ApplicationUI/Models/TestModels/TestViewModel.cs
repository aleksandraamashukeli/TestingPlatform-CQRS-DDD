using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationUI.Models.TestModels
{
    public class TestViewModel
    {
        public string TestName { get; set; }

        public DateTime? AddedOn { get; set; }

        public int PopularityScore { get; set; }

        public string TestDescription { get; set; }

        public string BackgroundImage { get; set; }

    }
}
