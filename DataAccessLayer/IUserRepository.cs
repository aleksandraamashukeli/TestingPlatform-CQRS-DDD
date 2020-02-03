using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserById(string id);
        Task<IdentityResult> SignUpUser(User entity );

        Task SignInUser(User entity);

        Task<IdentityResult> UpdateUser(User entity);

        Task<IdentityResult> DeleteUser(User entity);


            
    }
}
