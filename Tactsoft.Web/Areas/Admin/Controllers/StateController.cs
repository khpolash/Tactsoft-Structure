using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendGrid.Helpers.Errors.Model;
using Tactsoft.Application.Interfaces.Entities;
using Tactsoft.Application.ViewModels.VmEntities;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class StateController : Controller
{
    private readonly IStateRepository _stateRepository;
    private readonly ICountryRepository _countryRepository;
    private readonly IMapper _mapper;

    public StateController(IStateRepository stateRepository, IMapper mapper, ICountryRepository countryRepository)
    {
        _stateRepository = stateRepository;
        _mapper = mapper;
        _countryRepository = countryRepository;
    }

    // GET: StateController
    public async Task<ActionResult> Index()
    {
        var data = await _stateRepository.GetAllAsync(x => x.Country);
        return View(_mapper.Map<List<StateVm>>(data));
    }

    // GET: StateController/Details/5
    public async Task<ActionResult> Details(int id)
    {
        var data = await _stateRepository.FirstOrDefaultAsync(id, x => x.Country);
        return View(_mapper.Map<StateVm>(data));
    }

    // GET: StateController/Create
    public async Task<ActionResult> Create()
    {
        var model = new StateVm();
        model.CountryDropdown = await _countryRepository.GetDropdown();
        return View(model);
    }

    // POST: StateController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create(StateVm model)
    {
        if (ModelState.IsValid)
        {
            var entity = _mapper.Map<State>(model);
            await _stateRepository.InsertAsync(entity);
            return RedirectToAction("Index");
        }
        model.CountryDropdown = await _countryRepository.GetDropdown();
        return View(model);
    }

    // GET: StateController/Edit/5
    public async Task<ActionResult> Edit(int id)
    {
        var model = await _stateRepository.FirstOrDefaultAsync(id, x => x.Country);
        return View(_mapper.Map<StateVm>(model));
    }

    // POST: StateController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Edit(StateVm model)
    {
        if (ModelState.IsValid)
        {
            var entity = _mapper.Map<State>(model);
            await _stateRepository.UpdateAsync(entity);
            return RedirectToAction("Index");
        }
        model.CountryDropdown = await _countryRepository.GetDropdown();
        return View(model);
    }

    // GET: StateController/Delete/5
    public async Task<ActionResult> Delete(int id)
    {
        var data = await _stateRepository.FirstOrDefaultAsync(id, x => x.Country);
        return View(_mapper.Map<StateVm>(data));
    }

    // POST: StateController/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> DeleteConfirm(int id)
    {
        var data = await _stateRepository.FirstOrDefaultAsync(id);
        if (data == null)
            throw new NotFoundException();

        await _stateRepository.DeleteAsync(data);
        return RedirectToAction("Index");
    }
}
