using Microsoft.Extensions.DependencyInjection;
using RBACProject.Repositories.Interfaces;
using RBACProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBACProject.Repositories
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IClaimRepository, ClaimRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();

            return services;
        }
    }
}
