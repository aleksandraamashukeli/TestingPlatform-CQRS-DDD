using AutoMapper;
using DataAccessLayer;
using Infrastructure;
using MediatR;
using Services.Models.AnswerModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Answer.Commands
{
    public class CreateAnswer : IRequest<ResultResponse>
    {
        private readonly CreateAnswerModel answerModel;
        private readonly int questionId;

        public CreateAnswer(CreateAnswerModel answerModel, int QuestionId)
        {
            this.answerModel = answerModel;
            questionId = QuestionId;
        }


        public class CreateAnswerBodyHandler : IRequestHandler<CreateAnswer, ResultResponse>
        {
            private readonly IMapper mapper;
            private readonly IRepository<DataAccessLayer.Models.Answer> repository;

            public CreateAnswerBodyHandler(IMapper mapper, IRepository<DataAccessLayer.Models.Answer> repository)
            {
                this.mapper = mapper;
                this.repository = repository;
            }

            public async Task<ResultResponse> Handle(CreateAnswer request, CancellationToken cancellationToken)
            {
                var answer = mapper.Map<DataAccessLayer.Models.Answer>(request.answerModel);
                answer.QuestionId= request.questionId;
                repository.Add(answer);
                return await Task.FromResult(new ResultResponse());
            }
        }
    }
}
