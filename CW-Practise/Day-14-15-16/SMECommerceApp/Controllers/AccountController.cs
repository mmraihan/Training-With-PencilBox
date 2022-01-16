using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SMECommerce.Models.EntityModels;
using SMECommerceApp.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerceApp.Controllers
{
    public class AccountController : Controller
    {
        SignInManager<ApplicationUser> _signInManager;//-----User Login
        UserManager<ApplicationUser> _userManager; //--------User Create

        public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }




        public IActionResult Signup()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Signup(SignUpUserModelVM userModel)
        {
            
            
            if (ModelState.IsValid)
            {
                ApplicationUser applicationUser = new ApplicationUser()
                {
                    FirstName = userModel.FirstName,
                    LastName = userModel.LastName,
                    Address = userModel.Address,
                    Email = userModel.Email,
                    UserName = userModel.Email
                };
                var newUser=await _userManager.CreateAsync(applicationUser,userModel.Password);
               
                if (!newUser.Succeeded)
                {
                    foreach (var error in newUser.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                return RedirectToAction("Login");

            }
            return View();
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
                var user = await _userManager.FindByEmailAsync(signInUserModelVM.Email);
                if (user !=null)
                {
                    var result =await _signInManager.PasswordSignInAsync(signInUserModelVM.Email, signInUserModelVM.Password, false,false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError("", "Invalid Account");
                }
               
            }
            return View();
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            
            return RedirectToAction("Index", "Home");
        }
    }
}
