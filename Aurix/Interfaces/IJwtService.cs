using System.Security.Claims;
using Aurix.Enums;

namespace Aurix.Interfaces
{
    public interface IJwtService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
        Task<bool> ValidateTokenAsync(string token);
        IEnumerable<Claim> CreateClaims(Guid userId, string email, UserRole role);
    }
}
