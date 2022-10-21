using RBACProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBACProject.Services.Interfaces
{
    public interface IClaimService
    {
        List<Claim> GetAllClaims();

        Claim GetClaimById(int id);

        Claim AddClaim(int id, int roleId, int permissionId, EPolicy policy);

        Claim UpdateClaim(Claim claim);

        void DeleteClaim(int id);
    }
}
