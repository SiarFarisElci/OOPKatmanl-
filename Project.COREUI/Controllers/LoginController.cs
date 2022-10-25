using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.COREUI.ViemClasses;
using Ptoject.ENTITIES.Entities;
using System.Threading.Tasks;

namespace Project.COREUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginVM uservm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(uservm.UserName , uservm.Password , false , true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index" , "Category");
                }
                else
                {
                    ModelState.AddModelError("" , "Hatalı Kullanıcı adı veya sifre");
                }

            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index" , "Login");
        }
    }
}
