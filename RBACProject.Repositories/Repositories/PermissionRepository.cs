using System;
using System.Collections.Generic;
using System.Text;
using RBACProject.Repositories.Entities;
using RBACProject.Repositories.Interfaces;

namespace RBACProject.Repositories.Repositories
{
    class PermissionRepository : IPermissionRepository
    {
        private readonly IContext _contextPermission;

        public PermissionRepository(IContext contextPermission)
        {
            _contextPermission = contextPermission;
        }

        public Permission AddPermission(int id, string name, string description)
        {
            var newPermission = new Permission { Id = id, Name = name, Description = description };
            _contextPermission.Permissions.Add(newPermission);
            return newPermission;
        }

        public void DeletePermission(int id)
        {
            for (int i = 0; i < _contextPermission.Permissions.Count; i++)
            {
                if (_contextPermission.Permissions[i].Id == id)
                {
                    _contextPermission.Permissions.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Permission> GetAllPermissions()
        {
            return _contextPermission.Permissions;
        }

        public Permission GetPermissionById(int id)
        {
            for (int i = 0; i < _contextPermission.Permissions.Count; i++)
            {
                if (_contextPermission.Permissions[i].Id == id)
                {
                    return _contextPermission.Permissions[i];
                }
            }
            return null;
        }

        public Permission UpdatePermission(Permission permission)
        {
            for (int i = 0; i < _contextPermission.Permissions.Count; i++)
            {
                if (_contextPermission.Permissions[i].Id == permission.Id)
                {
                    _contextPermission.Permissions[i].Name = permission.Name;
                    _contextPermission.Permissions[i].Description = permission.Description;
                    return _contextPermission.Permissions[i];
                }
            }
            return null;
        }
    }
}
