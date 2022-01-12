using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories.Abstractions;
using SMECommerce.Services.Abstractions;
using SMECommerceApp.Models.IdentityModel;
using SMECommerceApp.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        
        private readonly IMapper _mapper;

        public AccountController(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public IActionResult Signup()
        {
            return View();
        }
        
        [HttpPost]
        public async Task <IActionResult> Signup(SignUpUserModelVM userModel)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<SignUpUserModel>(userModel);
                var newUser = await _accountRepository.CreateUser(user);
                if (!newUser.Succeeded)
                {
                    foreach (var error in newUser.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                return RedirectToAction("Success");
                                 

            }
            return View(userModel);
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(SignInUserModelVM signInUserModelVM)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<SignInUserModel>(signInUserModelVM);
                var result = await _accountRepository.SignInUser(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("List", "Product");
                }
                ModelState.AddModelError("", "Invalid Account");
            }
            return View(signInUserModelVM);
        }


        public async Task<IActionResult> Logout()
        {
            await _accountRepository.SignOutUser();
            return RedirectToAction("Index", "Home");
        }


        public  IActionResult Success()
        {
            return View();
        }

    }
}
