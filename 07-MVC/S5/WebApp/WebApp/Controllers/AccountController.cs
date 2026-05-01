using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    
    public class AccountController : Controller
    {
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                //IdentityUser user = new IdentityUser();
                ApplicationUser user = new ApplicationUser();
                user.UserName = newUser.UserName;
                user.Email = newUser.EmailAddress;
                user.PasswordHash = newUser.Password;
                user.FirstName = newUser.FirstName;
                user.LastName = newUser.LastName;

                IdentityResult result = await _userManager.CreateAsync(user, newUser.Password);

                //With password for hashing
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginUser)
        {
            if (ModelState.IsValid)
            {
              var user =await _userManager.FindByNameAsync(loginUser.UserName);
                if (user != null)
                {
                 Microsoft.AspNetCore.Identity.SignInResult result  =  await _signInManager.PasswordSignInAsync(user,loginUser.Password,false,false);
                    if(result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }else
                    {
                        ModelState.AddModelError("", "Password is not Valied");
                    }
                }
                ModelState.AddModelError("", "User is not Found");

            }
            return View();
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        //For Admin Creation
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult RegisterAdmin()
        {
            return View("Register");
        }
        [HttpPost]
        public async Task<IActionResult> RegisterAdmin(RegisterViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                //IdentityUser user = new IdentityUser();
                ApplicationUser user = new ApplicationUser();
                user.UserName = newUser.UserName;
                user.Email = newUser.EmailAddress;
                user.PasswordHash = newUser.Password;
                user.FirstName = newUser.FirstName;
                user.LastName = newUser.LastName;

                IdentityResult result = await _userManager.CreateAsync(user, newUser.Password);

                //With password for hashing
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }

    }
}
