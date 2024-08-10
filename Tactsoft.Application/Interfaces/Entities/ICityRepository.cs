using Microsoft.AspNetCore.Mvc.Rendering;
using Tactsoft.Infrastructure.Interfaces.BaseRepo;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Application.Interfaces.Entities;

public interface ICityRepository : IBaseRepository<City>
{
    Task<IEnumerable<SelectListItem>> GetDropdown(int? selected = 0);
}
