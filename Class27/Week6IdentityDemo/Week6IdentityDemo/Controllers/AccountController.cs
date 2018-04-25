using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Week6IdentityDemo.Models;
using Week6IdentityDemo.Models.ViewModels;

namespace Week6IdentityDemo.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<ApplicationUser> _signInManager;
        private UserManager<ApplicationUser> _userManager;

        public AccountController(SignInManager<ApplicationUser>
            signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = rvm.Email,
                    Email = rvm.Email,
                    FirstName = rvm.FirstName,
                    LastName = rvm.LastName,
                    BirthDate = rvm.Birthday,
                    FavoriteColor = rvm.FavoriteColor
                };

                var result = await _userManager.CreateAsync(user, rvm.Password);

                if (result.Succeeded)
                {
                    List<Claim> myClaims = new List<Claim>();
                    Claim claim = new Claim(ClaimTypes.Name, $"{rvm.FirstName} {rvm.LastName}",
                        ClaimValueTypes.String);
                    Claim claim1 = new Claim(ClaimTypes.Email, rvm.Email, ClaimValueTypes.Email);
                    Claim claim2 = new Claim(ClaimTypes.DateOfBirth, new DateTime
                        (rvm.Birthday.Year, rvm.Birthday.Month, rvm.Birthday.Day).ToString("u"),
                        ClaimValueTypes.DateTime);

                    myClaims.Add(claim);
                    myClaims.Add(claim1);
                    myClaims.Add(claim2);

                    await _userManager.AddClaimsAsync(user, myClaims);

                    // If we decided to attach these claims to an identity. 
                    //ClaimsIdentity ci = new ClaimsIdentity(myClaims);

                   await _userManager.AddToRoleAsync(user, ApplicationRoles.Member);

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    RedirectToAction("Index", "Home");
                }

            }
            return View();
        }

    }
}
