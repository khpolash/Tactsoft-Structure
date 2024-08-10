using Microsoft.AspNetCore.Mvc.Rendering;
using Tactsoft.Application.Interfaces.Entities;
using Tactsoft.Application.Repositories.BaseRepo;
using Tactsoft.Infrastructure.Persistence;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Application.Repositories.Entities;

public class CountryRepository : BaseRepository<Country>, ICountryRepository
{
    public CountryRepository(TactsoftDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<SelectListItem>> GetDropdown(long? selected = 0)
    {
        var date = await GetAllAsync();
        return date.Select(x => new SelectListItem
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = x.Id == selected
        });
    }
}
