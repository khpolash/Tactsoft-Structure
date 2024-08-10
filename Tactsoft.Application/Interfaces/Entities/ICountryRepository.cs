using Microsoft.AspNetCore.Mvc.Rendering;
using Tactsoft.Infrastructure.Interfaces.BaseRepo;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Application.Interfaces.Entities;

public interface ICountryRepository : IBaseRepository<Country>
{
    Task<IEnumerable<SelectListItem>> GetDropdown(int? selected = 0);
}
