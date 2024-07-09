using static Tactsoft.SharedKernel.Entities.Identities.IdentityModel;

namespace Tactsoft.SharedKernel.Core.Constants;

public class DefaultApplicationUsers
{
    public static User GetSuperUser()
    {
        var defaultUser = new User
        {
            UserName = "superadmin@localhost.com",
            Email = "superadmin@localhost.com",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
        };
        return defaultUser;
    }
}