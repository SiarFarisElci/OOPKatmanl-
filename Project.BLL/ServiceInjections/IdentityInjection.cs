using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Project.DAL.Context;
using Ptoject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    //Identity kullanıyorsanız hazır Identity lerion ldugu kutuphane


    public static class IdentityInjection
    {

        public static IServiceCollection AddIdentityService(this IServiceCollection services)
        {

            services.AddIdentity<AppUser, AppRole>(x =>
            {
                x.Password.RequireDigit = false;
                x.Password.RequireLowercase = false;
                x.Password.RequireUppercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequiredLength = 8;
            }).AddEntityFrameworkStores<MyContext>();

            return services;
        }



    }
}
