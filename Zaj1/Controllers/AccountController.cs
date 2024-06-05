using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Zaj1.Models;

namespace Zaj1.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> UserMgr { get; set; }
        private SignInManager<AppUser> SignInMgr { get; set; }

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            UserMgr = userManager;
            SignInMgr = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Register()
        {
            try
            {
                ViewBag.mesege="User jest już zarejestrowany";

                AppUser user = await UserMgr.FindByNameAsync("TestUser");
                if (user == null)
                {
                    user = new AppUser
                    {
                        UserName = "TestUser",
                        Email = "testuser@test.com",
                        FirstName="Jan",
                        LastName="Kowalski"
                    };
                    IdentityResult result = await UserMgr.CreateAsync(user, "TestPassword");
                    
                    ViewBag.mesege="User created";
                   
                }
            }
            catch (Exception ex)
            {
                ViewBag.mesege=ex.Message;
            }
            return View();
        }

        public async Task<IActionResult> Login()
        {
            try
            {
                var result = await SignInMgr.PasswordSignInAsync("TestUser", "TestPassword", false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.mesege="Niepoprawne dane logowania";
                }
            }
            catch (Exception ex)
            {
                ViewBag.mesege=ex.Message;
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
