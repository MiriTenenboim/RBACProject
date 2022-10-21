using System;
using System.Collections.Generic;
using System.Text;
using RBACProject.Repositories.Entities;

namespace RBACProject.Repositories
{
    public class MyDBContext : IContext
    {
        public List<Role> Roles { get; set; }
       
        public List<Permission> Permissions { get; set; }
       
        public List<Claim> Claims { get; set; }
    }
}
