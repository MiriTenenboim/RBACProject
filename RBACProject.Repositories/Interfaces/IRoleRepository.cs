using System;
using System.Collections.Generic;
using System.Text;
using RBACProject.Repositories.Entities;

namespace RBACProject.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        List<Role> GetAllRoles();

        Role GetRoleById(int id);

        Role AddRole(int id, string name, string description);

        Role UpdateRole(Role role);

        void DeleteRole(int id);
    }
}
