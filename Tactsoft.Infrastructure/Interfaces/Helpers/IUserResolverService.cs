using System.Security.Claims;

namespace Tactsoft.Infrastructure.Interfaces.Helpers;

public interface IUserResolverService
{
    ClaimsPrincipal GetUser();

    long CurentUserId { get; }

    public bool IsUserAuthorized();
}
