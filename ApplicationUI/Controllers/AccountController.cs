using ApplicationUI.Models.UserModels;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Models.UserModels;
using Services.User.Commands;
using Services.User.Queries;
using System.Threading.Tasks;

namespace ApplicationUI.Controllers
{
    public class AccountController :Controller
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public AccountController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public IActionResult Register() => View();
        public IActionResult Login() => View();


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var userDTO = _mapper.Map<SignUpUserModel>(viewModel);
                var result = await _mediator.Send(new CreateUser(userDTO));
                if (result.Succeeded)
                {
                    return RedirectToAction("Profile");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginViewModel viewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<SignInUserModel>(viewModel);
                var result = await _mediator.Send(new SignInUser(user));


                if (result.Succeeded)
                {
                    if (!string.IsNullOrWhiteSpace(returnUrl))
                        return Redirect(returnUrl);
                    else
                        return RedirectToAction("Index","Test");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }

            
        }
           
        [Authorize]
        public IActionResult Profile()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _mediator.Send(new SignOutUser());
            return RedirectToAction("Index", "Home");
        }

    }
}
