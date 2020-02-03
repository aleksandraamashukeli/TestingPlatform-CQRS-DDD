using MediatR;
using Services.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.User.Queries
{
    public class GetAllUsers : IRequest<IEnumerable<UserModel>>
    {
        
    }
}
