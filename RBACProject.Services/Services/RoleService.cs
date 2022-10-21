using RBACProject.Repositories.Entities;
using RBACProject.Repositories.Interfaces;
using RBACProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBACProject.Services.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;   
        }

        public Role AddRole(int id, string name, string description)
        {
            return _roleRepository.AddRole(id, name, description);
        }

        public void DeleteRole(int id)
        {
            _roleRepository.DeleteRole(id);
        }

        public List<Role> GetAllRoles()
        {
            return _roleRepository.GetAllRoles(); 
        }

        public Role GetRoleById(int id)
        {
            return _roleRepository.GetRoleById(id);
        }

        public Role UpdateRole(Role role)
        {
            return _roleRepository.UpdateRole(role);
        }
    }
}
