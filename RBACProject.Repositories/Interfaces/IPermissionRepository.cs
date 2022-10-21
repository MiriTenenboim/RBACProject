using System;
using System.Collections.Generic;
using System.Text;
using RBACProject.Repositories.Entities;

namespace RBACProject.Repositories.Interfaces
{
    public interface IPermissionRepository
    {
        List<Permission> GetAllPermissions();

        Permission GetPermissionById(int id);

        Permission AddPermission(int id, string name, string description);

        Permission UpdatePermission(Permission permission);

        void DeletePermission(int id);
    }
}
