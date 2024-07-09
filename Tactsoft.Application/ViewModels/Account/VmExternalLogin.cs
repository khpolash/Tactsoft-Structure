using System.ComponentModel.DataAnnotations;

namespace Tactsoft.Application.ViewModels.Account;

public class VmExternalLogin
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
