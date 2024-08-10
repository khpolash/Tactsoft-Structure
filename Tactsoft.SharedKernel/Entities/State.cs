using System.ComponentModel.DataAnnotations.Schema;
using Tactsoft.SharedKernel.Entities.BaseEntities;

namespace Tactsoft.SharedKernel.Entities;

public class State : AuditableEntity
{
    public State()
    {
        Citys = new HashSet<City>();
        Students = new HashSet<Student>();
    }
    public string Name { get; set; }
    public long CountryId { get; set; }

    [ForeignKey(nameof(CountryId))]
    public Country Country { get; set; }

    public ICollection<City> Citys { get; set; }
    public ICollection<Student> Students { get; set; }
}
