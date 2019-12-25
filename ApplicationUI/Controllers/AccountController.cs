using ApplicationUI.Models.UserModels;
using AutoMapper;
using Infrastructure;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Models.UserModels;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ApplicationUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService { get; set; }
        private IMapper _mapper { get; set; }
        private static UserProfileViewModel UserProfile { get; set; }

        public AccountController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginViewModel user)
        {
            var readUserModel = _mapper.Map<UserDTO>(user);
            UserProfile =_mapper.Map<UserProfileViewModel>(_userService.GetUser(readUserModel));

            if (_userService.CanAuthenticate(readUserModel))
            {
                await Authorize(user);
                return RedirectToAction("Profile");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserRegisterViewModel user)
        {
            if (ModelState.IsValid)
            {
                var createUserModel = _mapper.Map<UserDTO>(user);
                createUserModel.ProfileImage = ImageConverter.ImageToBase64(user.ProfileImage);

                _userService.RegisterUser(createUserModel);

                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("Cookies");
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult Profile()
        {
            return View(UserProfile);
        }

        private async Task Authorize(UserLoginViewModel user)
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Email, user.Email) };
            var userIdentity = new ClaimsIdentity(claims, "login");
            var principal = new ClaimsPrincipal(userIdentity);

            var props = new AuthenticationProperties();
            props.IsPersistent = user.RememberMe;

            await HttpContext.SignInAsync(principal,props);
        }
    }
}
