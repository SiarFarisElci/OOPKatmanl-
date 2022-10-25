using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREUI.ViemClasses;
using Ptoject.ENTITIES.Entities;
using System.Threading.Tasks;

namespace Project.COREUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
     
        UserManager<AppUser> _userManager;
        public RegisterController(UserManager<AppUser> userManager)
        {
      
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            if (model.Password == model.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser , model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("" , item.Description);
                    }
                }
            }
          

            return View(model);
        }
    }
}
