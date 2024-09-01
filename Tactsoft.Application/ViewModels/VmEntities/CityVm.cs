using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tactsoft.SharedKernel.Entities.BaseEntities;

namespace Tactsoft.Application.ViewModels.VmEntities;

public class CityVm : BaseEntity
{
    [Required(ErrorMessage = "The City name is required.")]
    [StringLength(85, ErrorMessage = "The City name cannot exceed 85 characters.")]
    public string Name { get; set; }
    public long StateId { get; set; }

    [ForeignKey(nameof(StateId))]
    public StateVm State { get; set; }


    public ICollection<StudentVm> Student { get; set; } = new HashSet<StudentVm>();
    public IEnumerable<SelectListItem> StateDropdown { get; set; }
}
