using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;
using Tactsoft.SharedKernel.Core.Default;
using Tactsoft.SharedKernel.Entities;
using Tactsoft.SharedKernel.Entities.BaseEntities;

namespace Tactsoft.Application.ViewModels.VmEntities;

public class StudentVm : BaseEntity
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
    public IFormFile ProfilePhotoFile { get; set; }

    [ForeignKey(nameof(CountryId))]
    public CountryVm Country { get; set; }
    [ForeignKey(nameof(StateId))]
    public StateVm State { get; set; }
    [ForeignKey(nameof(CityId))]
    public CityVm City { get; set; }


    public IEnumerable<SelectListItem> CountryDropdown { get; set; }
    public IEnumerable<SelectListItem> StateDropdown { get; set; }
    public IEnumerable<SelectListItem> CityDropdown { get; set; }

}
