using RBACProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBACProject.Services.Interfaces
{
    public interface IPermissionService
    {
        List<Permission> GetAllPermissions();

        Permission GetPermissionById(int id);

        Permission AddPermission(int id, string name, string description);

        Permission UpdatePermission(Permission permission);

        void DeletePermission(int id);
    }
}
