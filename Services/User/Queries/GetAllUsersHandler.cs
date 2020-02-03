using AutoMapper;
using DataAccessLayer;
using MediatR;
using Services.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.User.Queries
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsers, IEnumerable<UserModel>>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public GetAllUsersHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public Task<IEnumerable<UserModel>> Handle(GetAllUsers request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
