using RBACProject.Repositories.Entities;
using RBACProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBACProject.Services.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionService _permissionService;

        public PermissionService(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public Permission AddPermission(int id, string name, string description)
        {
            return _permissionService.AddPermission(id, name, description);
        }

        public void DeletePermission(int id)
        {
            _permissionService.DeletePermission(id);
        }

        public List<Permission> GetAllPermissions()
        {
            return _permissionService.GetAllPermissions();
        }

        public Permission GetPermissionById(int id)
        {
            return _permissionService.GetPermissionById(id);
        }

        public Permission UpdatePermission(Permission permission)
        {
            return _permissionService.UpdatePermission(permission);
        }
    }
}
