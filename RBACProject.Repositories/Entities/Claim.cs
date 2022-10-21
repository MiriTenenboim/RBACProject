using System;
using System.Collections.Generic;
using System.Text;

namespace RBACProject.Repositories.Entities
{
    public enum EPolicy { Allow, Deny }
    public class Claim
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public int PermissionId { get; set; }

        public EPolicy Policy { get; set; }

        public override string ToString()
        {
            return $"Claim: Id={this.Id} RoleId={this.RoleId} PermissionId={this.PermissionId} Policy={this.Policy}";
        }
    }
}
