using Microsoft.AspNetCore.Mvc.Rendering;
using Tactsoft.Infrastructure.Interfaces.BaseRepo;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Application.Interfaces.Entities;

public interface IStateRepository : IBaseRepository<State>
{
    Task<IEnumerable<SelectListItem>> GetDropdown(long? selected = 0);
    Task<IEnumerable<State>> StatesByCountry(long countryId);
}
