
using Microsoft.Extensions.DependencyInjection;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concrates;
using Project.DAL.Context;
using Project.DAL.Repositories.Abstrackts;
using Project.DAL.Repositories.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    public static class RepManServices
    {
        public static IServiceCollection AddRepManService(this IServiceCollection services)
        {

            //Repositories

            //Scoped , Transient , singleton
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IAppRoleRepository, AppRoleRepository>();
           



            //Managers

            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<ICustomerManager, CustomerManager>();
            services.AddScoped<IJobManager, JobManager>();
            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IAppRoleManager, AppRoleManager>();
            



            return services;



        }
    }
    }
