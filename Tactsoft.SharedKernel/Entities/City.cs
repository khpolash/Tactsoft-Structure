using System.ComponentModel.DataAnnotations.Schema;
using Tactsoft.SharedKernel.Entities.BaseEntities;

namespace Tactsoft.SharedKernel.Entities;

public class City : AuditableEntity
{
    public City()
    {
        Students = new HashSet<Student>();
    }
    public string Name { get; set; }
    public long StateId { get; set; }

    [ForeignKey(nameof(StateId))]
    public State State { get; set; }



    public ICollection<Student> Students { get; set; }
}
