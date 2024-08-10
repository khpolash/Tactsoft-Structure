using Tactsoft.SharedKernel.Entities.BaseEntities;

namespace Tactsoft.Application.ViewModels.VmEntities;

public class CountryVm : BaseEntity
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string CapitalCity { get; set; }

    public ICollection<StateVm> State { get; set; } = new HashSet<StateVm>();
    public ICollection<StudentVm> Student { get; set; } = new HashSet<StudentVm>();
}
