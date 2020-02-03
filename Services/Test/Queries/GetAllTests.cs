using AutoMapper;
using DataAccessLayer;
using MediatR;
using Services.Models.TestModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Test.Queries
{
    public class GetAllTests : IRequest<List<Services.Models.TestModels.DisplayTestModel>>
    {
        public class GetAllTestsHandler : IRequestHandler<GetAllTests, List<Services.Models.TestModels.DisplayTestModel>>
        {
            private readonly IMapper mapper;

            private readonly IRepository<DataAccessLayer.Models.Test> repository;

            public GetAllTestsHandler(IMapper mapper,IRepository<DataAccessLayer.Models.Test> repository)
            {
                this.mapper = mapper;
                this.repository = repository;
            }

            public Task<List<Services.Models.TestModels.DisplayTestModel>> Handle(GetAllTests request, CancellationToken cancellationToken)
            {
                var tests =repository.GetAll();
                var testDisplayModels = mapper.Map<List<Services.Models.TestModels.DisplayTestModel>>(tests);

                return Task.FromResult(testDisplayModels);
            }
        }
    }
}
