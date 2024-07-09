using Tactsoft.SharedKernel.Entities.BaseEntities;

namespace Tactsoft.Application.ViewModels.RolePermission;

public class UserViewModel : BaseEntity
{
    public string UserName { get; set; }

    public string Email { get; set; }
}
