using System.ComponentModel.DataAnnotations;

namespace Tactsoft.Application.ViewModels.Account;

public class VmLoginWithRecoveryCode
{
    [Required]
    [DataType(DataType.Text)]
    [Display(Name = "Recovery Code")]
    public string RecoveryCode { get; set; }
}
