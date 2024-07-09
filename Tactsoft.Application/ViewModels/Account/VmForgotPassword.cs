using System.ComponentModel.DataAnnotations;

namespace Tactsoft.Application.ViewModels.Account;

public class VmForgotPassword
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
