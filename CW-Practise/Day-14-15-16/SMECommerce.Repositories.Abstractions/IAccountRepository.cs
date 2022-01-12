using Microsoft.AspNetCore.Identity;
using SMECommerce.Models.EntityModels;
using SMECommerceApp.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerce.Repositories.Abstractions
{
    public interface IAccountRepository
    {
      
        Task<IdentityResult> CreateUser(SignUpUserModel userModel);
        Task<SignInResult> SignInUser(SignInUserModel signInModel);
        Task SignOutUser();
    }
}
