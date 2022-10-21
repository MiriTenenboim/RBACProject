using System;
using System.Collections.Generic;
using System.Text;
using RBACProject.Repositories.Entities;

namespace RBACProject.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        List<Claim> GetAllClaims();

        Claim GetClaimById(int id);

        Claim AddClaim(int id, int roleId, int permissionId, EPolicy policy);

        Claim UpdateClaim(Claim claim);

        void DeleteClaim(int id);
    }
}
