using Microsoft.AspNetCore.Identity;

namespace health_club.API.Repositories
{
	public interface ITokenRepository
	{
		string CreateJWTToken(IdentityUser user, List<string> roles);
	}
}

