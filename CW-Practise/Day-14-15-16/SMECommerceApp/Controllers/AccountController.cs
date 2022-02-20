using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SMECommerce.Models.EntityModels;
using SMECommerceApp.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerceApp.Controllers
{
    public class AccountController : Controller
    {
        SignInManager<ApplicationUser> _signInManager;//-----User Login
        UserManager<ApplicationUser> _userManager; //--------User Create
        IPasswordHasher<ApplicationUser> _passwordHasher;
        IConfiguration _config;

        public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IPasswordHasher<ApplicationUser> passwordHasher, IConfiguration config)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _passwordHasher = passwordHasher;
            _config = config;
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

        [HttpPost]
        public async Task<IActionResult> Token([FromBody] SignInUserModelVM model)
        {
            var user = await _userManager.FindByNameAsync(model.Email);

            if (user != null)
            {
                // verify password 

                var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, model.Password);

                if (result == PasswordVerificationResult.Success)
                {
                    // token generate for user. 

                    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                    var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                    var userClaims = await _userManager.GetClaimsAsync(user);


                    var claims = new Claim[]
                    {

                        new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                        new Claim(JwtRegisteredClaimNames.GivenName, user.UserName),
                        new Claim(JwtRegisteredClaimNames.Jti, (new Guid()).ToString())

                    }.Union(userClaims);

                   
                    var token = new JwtSecurityToken(
                        issuer: _config["Jwt:Issuer"],
                        audience: _config["Jwt:Issuer"],
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(120),
                        signingCredentials: signingCredentials
                        );


                    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                    return Ok(new { token = tokenString, expires = token.ValidTo });

                }


            }

            return BadRequest("User or Password could not match, please check");

        }
    }
}
