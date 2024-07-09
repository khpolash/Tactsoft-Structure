using System.ComponentModel.DataAnnotations;

namespace Tactsoft.Application.ViewModels.RolePermission;

public class AddRoleViewModel
{
    [Required]
    public string Name { get; set; }

    public string Description { get; set; }
}
