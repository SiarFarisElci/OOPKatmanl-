using Microsoft.AspNetCore.Identity;
using Project.DAL.Context;
using Project.DAL.Repositories.Abstrackts;
using Ptoject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concrates
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        //UserManager<AppUser> _userManager;
        //SignInManager<AppUser> _signInManager;

        public AppUserRepository(MyContext db) : base(db)
        {

        }

        //public async Task<bool> AddUser(AppUser item)
        //{
        //    //Sadece Asenkron olarak yaratılması (async marklı)  metotlar icerisinde await kullanabilirsiiniz.

        //    IdentityResult result = await _userManager.CreateAsync(item, item.PasswordHash);

        //    if (result.Succeeded)
        //    {
        //        await _signInManager.SignInAsync(item, isPersistent: false); //IsPersistend durumu Cookie de dursun mu durmasın mı
        //        return true;
        //    }

        //    return false;

    }
}

