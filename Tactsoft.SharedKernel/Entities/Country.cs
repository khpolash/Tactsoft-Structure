using Tactsoft.SharedKernel.Entities.BaseEntities;

namespace Tactsoft.SharedKernel.Entities;

public class Country : AuditableEntity
{
    public Country()
    {
        States = new HashSet<State>();
        Students = new HashSet<Student>();
    }
    public string Name { get; set; }
    public string Code { get; set; }
    public string CapitalCity { get; set; }

    public ICollection<State> States { get; set; }
    public ICollection<Student> Students { get; set; }

}
