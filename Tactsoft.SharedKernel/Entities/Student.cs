using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tactsoft.SharedKernel.Core.Default;
using Tactsoft.SharedKernel.Entities.BaseEntities;

namespace Tactsoft.SharedKernel.Entities;

public class Student : AuditableEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string MobileNumber { get; set; }
    public Gender Gender { get; set; }
    public long CountryId { get; set; }
    public long StateId { get; set; }
    public long CityId { get; set; }
    public string ZipCode { get; set; }
    public bool SSC { get; set; }
    public bool HSC { get; set; }
    public bool Bachelor { get; set; }
    public bool Masters { get; set; }
    public string ProfilePhoto { get; set; }

    [ForeignKey(nameof(CountryId))]
    public Country Country { get; set; }
    [ForeignKey(nameof(StateId))]
    public State State { get; set; }
    [ForeignKey(nameof(CityId))]
    public City City { get; set; }

}