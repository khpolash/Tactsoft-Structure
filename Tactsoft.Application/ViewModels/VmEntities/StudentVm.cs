using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tactsoft.SharedKernel.Core.Default;
using Tactsoft.SharedKernel.Entities;
using Tactsoft.SharedKernel.Entities.BaseEntities;

namespace Tactsoft.Application.ViewModels.VmEntities;

public class StudentVm : BaseEntity
{
    [Display(Name = "First Name")]
    [Required(ErrorMessage = "First Name is required.")]
    [StringLength(85, ErrorMessage = "First Name cannot be longer than 85 characters.")]
    public string FirstName { get; set; }

    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "Last Name is required.")]
    [StringLength(85, ErrorMessage = "Last Name cannot be longer than 85 characters.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Date of Birth is required.")]
    [DataType(DataType.Date)]
    [Display(Name = "Date of Birth")]
    public DateTime DateOfBirth { get; set; }

    [Display(Name = "Mobile Number")]
    [Required(ErrorMessage = "Mobile Number is required.")]
    [Phone(ErrorMessage = "Invalid phone number format.")]
    public string MobileNumber { get; set; }

    [Required(ErrorMessage = "Gender is required.")]
    public Gender Gender { get; set; }

    [Display(Name = "Country")]
    [Required(ErrorMessage = "Country is required.")]
    public long CountryId { get; set; }

    [Display(Name = "State")]
    [Required(ErrorMessage = "State is required.")]
    public long StateId { get; set; }

    [Display(Name = "City")]
    [Required(ErrorMessage = "City is required.")]
    public long CityId { get; set; }

    [Display(Name = "Zip Code")]
    [Required(ErrorMessage = "Zip Code is required.")]
    [StringLength(10, ErrorMessage = "Zip Code cannot be longer than 10 characters.")]
    public string ZipCode { get; set; }

    public bool SSC { get; set; }
    public bool HSC { get; set; }
    public bool Bachelor { get; set; }
    public bool Masters { get; set; }

    public string ProfilePhoto { get; set; }

    [Display(Name = "Upload Profile Photo")]
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
