using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREUI.ViemClasses;
using Ptoject.ENTITIES.Entities;
using System.Threading.Tasks;

namespace Project.COREUI.Controllers
{
    public class SettingController : Controller
    {
      
        UserManager<AppUser> _userManager;
        public SettingController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditVM evm = new UserEditVM();
            evm.FirstName = values.FirstName;
            evm.LastName = values.LastName;
            evm.Gender = values.Gender;
            evm.Email = values.Email;
            
            return View(evm);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditVM evm)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.FirstName = evm.FirstName;
            user.LastName = evm.LastName;
            user.Gender = evm.Gender;
            user.Email = evm.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user , evm.Password);

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index" , "Product");
            }
            else
            {
                ModelState.AddModelError("", "Hata");
            }

            return View(evm);
        }

       
    }


    
}
