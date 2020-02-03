using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.User.Queries
{
    class SignOutUserHandler : IRequestHandler<SignOutUser>
    {
        private readonly SignInManager<DataAccessLayer.Models.User> _signInManager;

        public SignOutUserHandler(SignInManager<DataAccessLayer.Models.User> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<Unit> Handle(SignOutUser request, CancellationToken cancellationToken)
        {
            await _signInManager.SignOutAsync();
            var result = await Unit.Task;
            return result;
        }
    }
}
