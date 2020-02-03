using MediatR;
using Services.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.User.Queries
{
    public class GetUserByEmail : IRequest<UserModel>
    {
        public  string email { get; set; }

        public GetUserByEmail(string email)
        {
            this.email = email;
        }
    }
}
