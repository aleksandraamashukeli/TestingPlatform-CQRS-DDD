using DataAccessLayer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Test.Queries
{
    public class GetTestById : IRequest<DataAccessLayer.Models.Test>
    {
        private readonly int id;

        public GetTestById(int id)
        {
            this.id = id;
        }

        public class GetTestByIdHandler : IRequestHandler<GetTestById, DataAccessLayer.Models.Test>
        {
            private readonly IRepository<DataAccessLayer.Models.Test> repository;

            public GetTestByIdHandler(IRepository<DataAccessLayer.Models.Test> repository)
            {
                this.repository = repository;
            }

            public async Task<DataAccessLayer.Models.Test> Handle(GetTestById request, CancellationToken cancellationToken)
            {
                var test =repository.getEntityById(request.id);
                return await Task.FromResult(test);
            }
        }
    }
}
