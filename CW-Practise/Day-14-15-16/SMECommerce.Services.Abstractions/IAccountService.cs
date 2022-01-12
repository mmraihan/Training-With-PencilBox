using Microsoft.AspNetCore.Identity;
using SMECommerceApp.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerce.Services.Abstractions
{
   public interface IAccountService
    {
      
        Task<IdentityResult> AddUser(SignUpUserModel signUpUserModel);
    }
}
