using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendGrid.Helpers.Errors.Model;
using Tactsoft.Application.Interfaces.Entities;
using Tactsoft.Application.Repositories.Entities;
using Tactsoft.Application.ViewModels.VmEntities;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class CityController : Controller
{
    private readonly ICityRepository _cityRepository;
    private readonly IStateRepository _stateRepository;
    private readonly IMapper _mapper;

    public CityController(ICityRepository cityRepository, IMapper mapper, IStateRepository stateRepository)
    {
        _cityRepository = cityRepository;
        _mapper = mapper;
        _stateRepository = stateRepository;
    }

    // GET: CityController
    public async Task<ActionResult> Index()
    {
        var city = await _cityRepository.GetAllAsync(x => x.State);
        return View(_mapper.Map<List<CityVm>>(city));
    }

    // GET: CityController/Details/5
    public async Task<ActionResult> Details(int id)
    {
        var data = await _cityRepository.FirstOrDefaultAsync(id, x => x.State);
        return View(_mapper.Map<CityVm>(data));
    }

    // GET: CityController/Create
    public async Task<ActionResult> Create()
    {
        var model = new CityVm();
        model.StateDropdown = await _stateRepository.GetDropdown();
        return View(model);
    }

    // POST: CityController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create(CityVm model)
    {
        if (ModelState.IsValid)
        {
            var entity = _mapper.Map<City>(model);
            await _cityRepository.InsertAsync(entity);
            return RedirectToAction("Index");
        }
        model.StateDropdown = await _stateRepository.GetDropdown();
        return View(model);
    }

    // GET: CityController/Edit/5
    public async Task<ActionResult> Edit(int id)
    {
        var city = await _cityRepository.FirstOrDefaultAsync(id, x => x.State);
        var model = _mapper.Map<CityVm>(city);
        model.StateDropdown = await _stateRepository.GetDropdown(city.StateId);
        return View(model);
    }

    // POST: CityController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Edit(CityVm model)
    {
        if (ModelState.IsValid)
        {
            var entity = _mapper.Map<City>(model);
            await _cityRepository.UpdateAsync(entity);
            return RedirectToAction("Index");
        }
        model.StateDropdown = await _stateRepository.GetDropdown();
        return View(model);
    }

    // GET: CityController/Delete/5
    public async Task<ActionResult> Delete(int id)
    {
        var data = await _cityRepository.FirstOrDefaultAsync(id, x => x.State);
        return View(_mapper.Map<CityVm>(data));
    }

    // POST: CityController/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> DeleteConfirm(int id)
    {
        var data = await _cityRepository.FirstOrDefaultAsync(id);
        if (data == null)
            throw new NotFoundException();

        await _cityRepository.DeleteAsync(data);
        return RedirectToAction("Index");
    }
}
