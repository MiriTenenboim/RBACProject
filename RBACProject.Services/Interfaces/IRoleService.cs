using RBACProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBACProject.Services.Interfaces
{
    public interface IRoleService
    {
        List<Role> GetAllRoles();

        Role GetRoleById(int id);

        Role AddRole(int id, string name, string description);

        Role UpdateRole(Role role);

        void DeleteRole(int id);
    }
}
