using AutoMapper;
using DataAccessLayer;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.User.Queries
{
    public class SignInUserHandler : IRequestHandler<SignInUser, SignInResult>
    {
        private readonly SignInManager<DataAccessLayer.Models.User> _signInManager;
        private readonly UserManager<DataAccessLayer.Models.User> _userManager;
        private readonly IMapper _mapper;

        public SignInUserHandler(SignInManager<DataAccessLayer.Models.User> signInManager,
            UserManager<DataAccessLayer.Models.User> userManager,
            IMapper mapper)
        {
           _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<SignInResult> Handle(SignInUser request, CancellationToken cancellationToken)
        {
            await _signInManager.SignOutAsync();
            var user =await  _userManager.FindByEmailAsync(request.user.Email);
            var result = await _signInManager.PasswordSignInAsync(user,request.user.Password, false, false);
            return result;
        }
    }
}
