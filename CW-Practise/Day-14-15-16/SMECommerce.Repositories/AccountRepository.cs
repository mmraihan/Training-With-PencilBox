using Microsoft.AspNetCore.Identity;
using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories.Abstractions;
using SMECommerceApp.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerce.Repositories
{
    public class AccountRepository : IAccountRepository
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
           _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task <IdentityResult> CreateUser(SignUpUserModel userModel)
        {
            var user = new ApplicationUser()
            {
                FirstName=userModel.FirstName,
                LastName=userModel.LastName,
                Address=userModel.Address,
                Email = userModel.Email,
                UserName = userModel.Email
            };

            var result = await _userManager.CreateAsync(user, userModel.Password);
            return result;
        }

        public async Task<SignInResult> SignInUser(SignInUserModel signInModel)
        {
           var result=await _signInManager.PasswordSignInAsync(signInModel.Email, signInModel.Password, false, false);
            return result;
        }

        public async Task SignOutUser()
        {
            await _signInManager.SignOutAsync();
        }


    }
}
