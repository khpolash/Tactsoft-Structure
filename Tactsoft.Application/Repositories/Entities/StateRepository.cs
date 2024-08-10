using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tactsoft.Application.Interfaces.Entities;
using Tactsoft.Application.Repositories.BaseRepo;
using Tactsoft.Infrastructure.Persistence;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Application.Repositories.Entities;

public class StateRepository : BaseRepository<State>, IStateRepository
{
    public StateRepository(TactsoftDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<SelectListItem>> GetDropdown(long? selected = 0)
    {
        var state = await GetAllAsync();
        return state.Select(x => new SelectListItem
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = x.Id == selected
        });
    }

    public async Task<IEnumerable<State>> StatesByCountry(long countryId)
    {
        return await GetAll().Where(x => x.CountryId == countryId).ToListAsync();
    }
}
