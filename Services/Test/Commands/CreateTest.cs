using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Models;
using Infrastructure;
using MediatR;
using Services.Models.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Test.Commands
{
    public class CreateTest :IRequest<ResultResponse>
    {
        private readonly CreateTestModel testModel;

        public CreateTest(CreateTestModel testModel)
        {
            this.testModel = testModel;
        }


        public class CreateTestHandler : IRequestHandler<CreateTest, ResultResponse>
        {
            private readonly IMapper mapper;
            private readonly IRepository<DataAccessLayer.Models.Test> repository;

            public CreateTestHandler(IMapper mapper, IRepository<DataAccessLayer.Models.Test> repository)
            {
                this.mapper = mapper;
                this.repository = repository;
            }

            public async Task<ResultResponse> Handle(CreateTest request, CancellationToken cancellationToken)
            {
                var test = mapper.Map<DataAccessLayer.Models.Test>(request.testModel);
                repository.Add(test);
                await repository.SaveChanges();
                return await Task.FromResult(new ResultResponse());
            }
        }
    }
}
