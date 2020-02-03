using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public UserRepository(  UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IdentityResult> DeleteUser(User entity)
        {
            var result =await userManager.DeleteAsync(entity);
            return result;
        }

        public async Task<User> GetUserByEmail (string email)
        {
            var user = await userManager.FindByEmailAsync(email);
            
            return user;
        }

        public async Task<User> GetUserById(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            return user;
        }

        public async Task SignInUser(User entity)
        {
            
        }

        public async Task<IdentityResult> SignUpUser(User entity)
        {
            var result = await userManager.CreateAsync(entity);
            return result;
        }

        public Task<IdentityResult> UpdateUser(User entity)
        {
            throw new NotImplementedException();
        }


    }
}
