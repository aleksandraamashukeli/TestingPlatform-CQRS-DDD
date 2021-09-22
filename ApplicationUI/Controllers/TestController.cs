using ApplicationUI.Models.TestModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Services.Models.TestModels;
using System.Security.Claims;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using Infrastructure;
using MediatR;
using Services.Test.Commands;
using Services.Test.Queries;
using System.Linq;

namespace ApplicationUI.Controllers
{

    [Authorize]
    public class TestController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public TestController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public IActionResult Index() => View();


        [HttpGet]
        public IActionResult CreateTest() => View();
        

        [HttpPost]
        public async Task<IActionResult> CreateTestAsync([FromBody]CreateTestViewModel json)
        {

            var test = _mapper.Map<CreateTestModel>(json);
            test.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            await _mediator.Send(new CreateTest(test));
            return RedirectToAction("Index","Test");
        }

        [HttpPost]
        public async Task<int> SubmitTest([FromBody] SubmitTestViewModel submitTest)
        {
            var score = 0;
            var test = await _mediator.Send(new GetTestById(submitTest.TestId));
            foreach (var question in submitTest.FinishedQuestions)
            {
                var currentQuestion = test.Questions.Single(q => q.Id == question.QuestionId);

                var correctAnswer = currentQuestion.Answers.Find(a => a.IsCorrect == true);
                if (question.AnswerId == correctAnswer.Id)
                {
                    score++;
                }

            }
            return score;
        }


        public async Task<IActionResult> TestPage(int id)
        {
            var test =await _mediator.Send(new GetTestById(id));
            
            var d = 12;
            
            return View(test);  
        }

        public async Task<string> GetMostPopularTests()
        {
            return null;
        }
        public async Task<string> GetNewestTests()
        {
            return null;
        }
        public async Task<string> GetAllTests()
        {
            var result = await _mediator.Send(new GetAllTests());
            return JsonConvert.SerializeObject(result);
        }

    }
}
