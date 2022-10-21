using System.Collections.Generic;
using RBACProject.Repositories.Entities;
using System;
using System.Text;

namespace RBACProject.Repositories
{
    public interface IContext
    {
        List<Role> Roles { get; set; }

        List<Permission> Permissions { get; set; }

        List<Claim> Claims { get; set; }
    }
}