using System;
using System.Collections.Generic;
using System.Text;
using RBACProject.Repositories.Entities;
using RBACProject.Repositories.Interfaces;

namespace RBACProject.Repositories.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IContext _contextRole;

        public RoleRepository(IContext context)
        {
            _contextRole = context;
        }

        public Role AddRole(int id, string name, string description)
        {
            var newRole = new Role { Id = id, Name = name, Description = description };
            _contextRole.Roles.Add(newRole);
            return newRole;
        }

        public void DeleteRole(int id)
        {
            for (int i = 0; i < _contextRole.Roles.Count; i++)
            {
                if (_contextRole.Roles[i].Id == id)
                {
                    _contextRole.Roles.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Role> GetAllRoles()
        {
            return _contextRole.Roles;
        }

        public Role GetRoleById(int id)
        {
            for (int i = 0; i < _contextRole.Roles.Count; i++)
            {
                if (_contextRole.Roles[i].Id == id)
                {
                    return _contextRole.Roles[i];
                }
            }
            return null;
        }

        public Role UpdateRole(Role role)
        {
            for (int i = 0; i < _contextRole.Roles.Count; i++)
            {
                if (_contextRole.Roles[i].Id == role.Id)
                {
                    _contextRole.Roles[i].Name = role.Name;
                    _contextRole.Roles[i].Description = role.Description;
                    return _contextRole.Roles[i];
                }
            }
            return null;
        }
    }
}
