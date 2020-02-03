using AutoMapper;
using DataAccessLayer;
using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.User.Commands
{
    public class CreateUserHandler : IRequestHandler<CreateUser, IdentityResult>
    {
        private readonly UserManager<DataAccessLayer.Models.User> _userManager;
        private readonly IMapper _mapper;

        public CreateUserHandler(UserManager<DataAccessLayer.Models.User> userManager,IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public  async Task<IdentityResult> Handle(CreateUser request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<DataAccessLayer.Models.User>(request.user);
            var result = await _userManager.CreateAsync(user,request.user.Password);
            return result;
        }
    }
}
