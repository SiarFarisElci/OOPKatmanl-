using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    public static class DbContextServices
    {
        public static IServiceCollection AddContextService(this IServiceCollection services)
        {
            ServiceProvider provider = services.BuildServiceProvider();

            //Sakin IConfiguration kullanırken Castle kutuphanesini kullanmayın..Kullanacağınız kutuphane Microsoft.Extensions.Configuration olmak zorundadır..

            IConfiguration configuration = provider.GetService<IConfiguration>(); //Calısan bir projenin configurationunu yapıyoruzz

            services.AddDbContextPool<MyContext>(options => options.UseSqlServer(configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies());

            return services;
        }
    }
}
