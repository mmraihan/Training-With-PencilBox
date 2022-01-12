using Microsoft.AspNetCore.Identity;
using SMECommerce.Repositories.Abstractions;
using SMECommerce.Services.Abstractions;
using SMECommerceApp.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerce.Services
{
    
   public class AccountService : IAccountService
    {

        private readonly IAccountRepository _accountRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountService(IAccountRepository accountRepository, UserManager<IdentityUser> userManager) 
        {
            _accountRepository = accountRepository;
            _userManager = userManager;
        }

        public async Task<IdentityResult> AddUser(SignUpUserModel signUpUserModel)
        {
           var user= await _accountRepository.CreateUser(signUpUserModel);
           return user;
        }
    }
}
