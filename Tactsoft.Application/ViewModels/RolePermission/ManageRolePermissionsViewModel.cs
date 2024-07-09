using System.ComponentModel.DataAnnotations;
using Tactsoft.SharedKernel.Core.Helpers;

namespace Tactsoft.Application.ViewModels.RolePermission;

public class ManageRolePermissionsViewModel
{
    [Required]
    public long RoleId { get; set; }

    public string RoleName { get; set; }

    public string PermissionValue { get; set; }

    public PaginatedList<ManageClaimViewModel> ManagePermissionsViewModel { get; set; }
}
