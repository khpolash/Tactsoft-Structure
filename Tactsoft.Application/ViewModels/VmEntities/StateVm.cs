using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tactsoft.SharedKernel.Entities.BaseEntities;

namespace Tactsoft.Application.ViewModels.VmEntities;

public class StateVm : BaseEntity
{
    [Required(ErrorMessage = "The State name is required.")]
    [StringLength(85, ErrorMessage = "The State name cannot exceed 85 characters.")]
    public string Name { get; set; }

    public long CountryId { get; set; }

    [ForeignKey(nameof(CountryId))]
    public CountryVm Country { get; set; }


    public ICollection<CityVm> City { get; set; } = new HashSet<CityVm>();
    public ICollection<StudentVm> Student { get; set; } = new HashSet<StudentVm>();

    public IEnumerable<SelectListItem> CountryDropdown { get; set; }
}
