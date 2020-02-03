using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace ApplicationUI.Models.TestModels
{
    public class CreateTestViewModel
    {
        public string UserId { get; set; }
        public string TestName { get; set; }
        public string TestDescription { get; set; }
        public string BackgroundImage { get; set; }
        public IEnumerable<CreateQuestionViewModel> Questions { get; set; }
    }
}
