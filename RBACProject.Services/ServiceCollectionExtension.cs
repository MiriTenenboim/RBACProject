using Microsoft.Extensions.DependencyInjection;
using RBACProject.Repositories;
using RBACProject.Services.Interfaces;
using RBACProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBACProject.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IClaimService, ClaimService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IRoleService, RoleService>();

            services.AddRepositories();

            return services;
        }
    }
}
