using RBACProject.Repositories;
using RBACProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBACProject.Mock
{
    public class MockContext : IContext
    {
        public List<Role> Roles { get; set; }
        
        public List<Permission> Permissions { get; set; }
        
        public List<Claim> Claims { get; set; }
    }
}
