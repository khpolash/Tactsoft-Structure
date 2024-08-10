using Microsoft.AspNetCore.Mvc.Rendering;
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

    public async Task<IEnumerable<SelectListItem>> GetDropdown(int? selected = 0)
    {
        var state = await GetAllAsync();
        return state.Select(x => new SelectListItem
        {
            Text = x.Name,
            Value = x.Id.ToString(),
            Selected = x.Id == selected
        });
    }
}
