using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ecom.Models;

namespace Ecom.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<ApplicationUser> _signInManager;
        private UserManager<ApplicationUser> _userManager;

        public AccountController(SignInManager<ApplicationUser> signinManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signinManager;
            _userManager = userManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser()
                {
                    UserName = rvm.Email,
                    Email = rvm.Email,
                    FirstName = rvm.FirstName,
                    LastName = rvm.LastName,
                    Clan = rvm.Clan,
                    Class = rvm.Class
                };
                //Create the user in the database using the user manager passed in from config
                var result = await _userManager.CreateAsync(user, rvm.Password);
                //If user was added build and add their claims
                if (result.Succeeded)
                {
                    List<Claim> myClaims = new List<Claim>();
                    Claim nameClaim = new Claim(ClaimTypes.Name, $"{rvm.FirstName} {rvm.LastName}",
                        ClaimValueTypes.String);
                    Claim emailClaim = new Claim(ClaimTypes.Email, rvm.Email, ClaimValueTypes.Email);
                    Claim clanClaim = new Claim("clanCkeck", rvm.Clan.ToString(), ClaimValueTypes.String); 
                    Claim classClaim = new Claim("classCheck", rvm.Class.ToString(), ClaimValueTypes.String);

                    myClaims.Add(nameClaim);
                    myClaims.Add(emailClaim);
                    myClaims.Add(clanClaim);
                    myClaims.Add(classClaim);

                    //Add the claims to the user in the db
                    await _userManager.AddClaimsAsync(user, myClaims);
                    //Add the user tot he memebrs role
                    await _userManager.AddToRoleAsync(user, ApplicationRoles.Member);
                    //Sign the user in
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    //Redirect to the home page
                    RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            //clear all external logins to ensure a new and clean login
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, false, false);

                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(lvm.Email);
                    var role = await _userManager.IsInRoleAsync(user, ApplicationRoles.Admin);

                    if (await _userManager.IsInRoleAsync(user, ApplicationRoles.Admin))
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            return View(lvm);
        }
    }
}