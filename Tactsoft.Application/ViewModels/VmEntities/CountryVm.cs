using System.ComponentModel.DataAnnotations;
using Tactsoft.SharedKernel.Entities.BaseEntities;

namespace Tactsoft.Application.ViewModels.VmEntities;

public class CountryVm : BaseEntity
{
    [Required(ErrorMessage = "The country name is required.")]
    [StringLength(85, ErrorMessage = "The country name cannot exceed 85 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The country code is required.")]
    [StringLength(10, ErrorMessage = "The country code cannot exceed 10 characters.")]
    public string Code { get; set; }

    [StringLength(85, ErrorMessage = "The capital city cannot exceed 85 characters.")]
    public string CapitalCity { get; set; }

    public ICollection<StateVm> State { get; set; } = new HashSet<StateVm>();
    public ICollection<StudentVm> Student { get; set; } = new HashSet<StudentVm>();
}
