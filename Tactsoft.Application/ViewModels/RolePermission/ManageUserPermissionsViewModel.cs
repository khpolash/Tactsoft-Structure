﻿using Tactsoft.SharedKernel.Core.Helpers;

namespace Tactsoft.Application.ViewModels.RolePermission;

public class ManageUserPermissionsViewModel
{
    public long UserId { get; set; }

    public string UserName { get; set; }

    public string PermissionValue { get; set; }

    public PaginatedList<ManageUserClaimViewModel> ManagePermissionsViewModel { get; set; }
}
