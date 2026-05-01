using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        UserManager<IdentityUser> _userManager;
        SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
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
                IdentityUser user = new IdentityUser();
                user.UserName = newUser.UserName;
                user.Email = newUser.EmailAddress;
                user.PasswordHash = newUser.Password;

                IdentityResult result = await _userManager.CreateAsync(user); //With password for hashing
                if (result.Succeeded)
                {
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
              IdentityUser user =await _userManager.FindByNameAsync(loginUser.UserName);
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
    }
}
