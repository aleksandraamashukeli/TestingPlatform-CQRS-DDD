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
    class GetUserByEmailHandler : IRequestHandler<GetUserByEmail, UserModel>
    {

        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public GetUserByEmailHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }


        public async Task<UserModel> Handle(GetUserByEmail request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByEmail(request.email);
            var result = _mapper.Map<UserModel>(user);
            return result;
        }
    }
}
