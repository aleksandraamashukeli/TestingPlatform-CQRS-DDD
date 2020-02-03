using MediatR;
using Microsoft.AspNetCore.Identity;
using Services.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.User.Queries
{
    public class SignInUser : IRequest<SignInResult>
    {
        public SignInUserModel user { get; set; }

        public SignInUser(SignInUserModel user)
        {
            this.user = user;
        }
    }
}
