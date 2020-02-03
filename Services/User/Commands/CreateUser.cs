using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Services.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.User.Commands
{
    public class CreateUser : IRequest<IdentityResult>
    {
        public  SignUpUserModel user { get; set; }

        public CreateUser(SignUpUserModel user)
        {
            this.user = user;
        }
    }
}
