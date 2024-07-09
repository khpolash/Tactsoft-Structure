using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Tactsoft.Infrastructure.Interfaces.Helpers;

namespace Tactsoft.Application.Repositories.Helpers;

public class UserResolverService(IHttpContextAccessor httpContextAccessor) : IUserResolverService
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public long CurentUserId => long.TryParse(
            _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier),
            out var userId)
        ? userId
        : 0;

    public ClaimsPrincipal GetUser() { return _httpContextAccessor.HttpContext.User; }

    public bool IsUserAuthorized()
    { return _httpContextAccessor.HttpContext?.User?.Identity?.IsAuthenticated ?? false; }
}
