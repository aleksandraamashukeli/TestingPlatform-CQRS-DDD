using AutoMapper;
using DataAccessLayer;
using Infrastructure;
using MediatR;
using Services.Models.QuestionModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Question.Commands
{
    public class CreateQuestion :IRequest<ResultResponse>
    {
        private readonly CreateQuestionModel questionModel;
        private readonly int testId;

        public CreateQuestion(CreateQuestionModel questionModel,int testId)
        {
            this.questionModel = questionModel;
            this.testId = testId;
        }


        public class CreateQuestionHandler : IRequestHandler<CreateQuestion, ResultResponse>
        {
            private readonly IMapper mapper;
            private readonly IRepository<DataAccessLayer.Models.Question> repository;

            public CreateQuestionHandler(IMapper mapper,IRepository<DataAccessLayer.Models.Question> repository)
            {
                this.mapper = mapper;
                this.repository = repository;
            }
            public async Task<ResultResponse> Handle(CreateQuestion request, CancellationToken cancellationToken)
            {
                var question = mapper.Map<DataAccessLayer.Models.Question>(request.questionModel);
                question.TestId = request.testId;
                repository.Add(question);
                return await Task.FromResult(new ResultResponse());
            }
        }
    }
}
