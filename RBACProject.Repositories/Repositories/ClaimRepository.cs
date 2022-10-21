using System;
using System.Collections.Generic;
using System.Text;
using RBACProject.Repositories.Entities;
using RBACProject.Repositories.Interfaces;

namespace RBACProject.Repositories.Repositories
{
    class ClaimRepository : IClaimRepository
    {
        private readonly IContext _contextClaim;

        public ClaimRepository(IContext contextClaim)
        {
            _contextClaim = contextClaim;
        }

        public Claim AddClaim(int id, int roleId, int permissionId, EPolicy policy)
        {
            var newClaim = new Claim { Id = id, RoleId = roleId, PermissionId = permissionId, Policy = policy };
            _contextClaim.Claims.Add(newClaim);
            return newClaim;
        }

        public void DeleteClaim(int id)
        {
            for (int i = 0; i < _contextClaim.Claims.Count; i++)
            {
                if (_contextClaim.Claims[i].Id == id)
                {
                    _contextClaim.Claims.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Claim> GetAllClaims()
        {
            return _contextClaim.Claims;
        }

        public Claim GetClaimById(int id)
        {
            for (int i = 0; i < _contextClaim.Claims.Count; i++)
            {
                if (_contextClaim.Claims[i].Id == id)
                {
                    return _contextClaim.Claims[i];
                }
            }
            return null;
        }

        public Claim UpdateClaim(Claim claim)
        {
            for (int i = 0; i < _contextClaim.Claims.Count; i++)
            {
                if (_contextClaim.Claims[i].Id == claim.Id)
                {
                    _contextClaim.Claims[i].RoleId = claim.RoleId;
                    _contextClaim.Claims[i].PermissionId = claim.PermissionId;
                    _contextClaim.Claims[i].Policy = claim.Policy;
                    return _contextClaim.Claims[i];
                }
            }
            return null;
        }
    }
}
