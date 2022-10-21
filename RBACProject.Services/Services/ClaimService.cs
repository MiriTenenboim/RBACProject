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
    public class ClaimService : IClaimService
    {
        private readonly IClaimRepository _claimRepository;

        public ClaimService(IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;
        }

        public Claim AddClaim(int id, int roleId, int permissionId, EPolicy policy)
        {
            return _claimRepository.AddClaim(id, roleId, permissionId, policy);
        }

        public void DeleteClaim(int id)
        {
            _claimRepository.DeleteClaim(id);
        }

        public List<Claim> GetAllClaims()
        {
            return _claimRepository.GetAllClaims(); 
        }

        public Claim GetClaimById(int id)
        {
            return _claimRepository.GetClaimById(id);
        }

        public Claim UpdateClaim(Claim claim)
        {
            return _claimRepository.UpdateClaim(claim);
        }
    }
}
