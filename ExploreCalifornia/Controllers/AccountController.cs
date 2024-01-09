using ExploreCalifornia.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace ExploreCalifornia.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> manager_users;
        private readonly SignInManager<IdentityUser> manager_signin;

        public AccountController(UserManager<IdentityUser> manager_users, SignInManager<IdentityUser> manager_signin)
        {
            this.manager_users = manager_users;
            this.manager_signin = manager_signin;
        }

        [HttpGet]
        [Route("Register")]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        [Route("Register")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registration)
        {
            if (!ModelState.IsValid) { return View(registration); }

            IdentityUser new_user = new IdentityUser()
            {
                Email = registration.EmailAddress,
                UserName = registration.UserName
            };

            IdentityResult result = await manager_users.CreateAsync(new_user, registration.Password);

            if (!result.Succeeded)
            {
                foreach (String error in result.Errors.Select(x => x.Description))
                {
                    ModelState.AddModelError("", error);
                }
                return View();
            }

            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login_details, String returnURL=null)
        {
            if (!ModelState.IsValid) { return View(login_details); }

            SignInResult result = await manager_signin.PasswordSignInAsync(
                    login_details.UserName, login_details.Password, login_details.RememberMe, false
                );

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Account not found or Invalid Password.");
                return View();
            }

            if(String.IsNullOrEmpty(returnURL)){return RedirectToAction("Index", "Home");}
            return Redirect(returnURL);
        }

        [HttpPost]
        public async Task<IActionResult> Logout(String returnURL = null)
        {
            await manager_signin.SignOutAsync();

            if (String.IsNullOrEmpty(returnURL)) { return RedirectToAction("Index", "Home"); }
            return Redirect(returnURL);
        }
    }
}
