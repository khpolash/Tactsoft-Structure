using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SendGrid.Helpers.Errors.Model;
using Tactsoft.Application.Interfaces.Entities;
using Tactsoft.Application.ViewModels.VmEntities;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Web.Areas.Admin.Controllers;
[Area("Admin")]
public class CountryController : Controller
{
    private readonly ICountryRepository _countryRepository;
    private readonly IMapper _mapper;

    public CountryController(ICountryRepository countryRepository, IMapper mapper)
    {
        _countryRepository = countryRepository;
        _mapper = mapper;
    }

    // GET: CountryController
    public async Task<ActionResult> Index()
    {
        var data = await _countryRepository.GetAllAsync();
        return View(_mapper.Map<List<CountryVm>>(data));
    }

    // GET: CountryController/Details/5
    public async Task<ActionResult> Details(int id)
    {
        var data = await _countryRepository.FirstOrDefaultAsync(id);
        return View(_mapper.Map<CountryVm>(data));
    }

    // GET: CountryController/Create
    public ActionResult Create()
    {
        var model = new CountryVm();
        return View(model);
    }

    // POST: CountryController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create(CountryVm model)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<Country>(model);
                await _countryRepository.InsertAsync(entity);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        catch (Exception ex)
        {
            return View(ex);
        }
    }

    // GET: CountryController/Edit/5
    public async Task<ActionResult> Edit(int id)
    {
        var model = await _countryRepository.FirstOrDefaultAsync(id);
        return View(_mapper.Map<CountryVm>(model));
    }

    // POST: CountryController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Edit(CountryVm model)
    {
        if (ModelState.IsValid)
        {
            var entity = _mapper.Map<Country>(model);
            await _countryRepository.UpdateAsync(entity);
            return RedirectToAction(nameof(Index));
        }
        return View(model);
    }

    // GET: CountryController/Delete/5
    public async Task<ActionResult> Delete(int id)
    {
        var model = await _countryRepository.FirstOrDefaultAsync(id);
        return View(_mapper.Map<CountryVm>(model));
    }

    // POST: CountryController/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> DeleteConfirm(int id)
    {
        var data = await _countryRepository.FirstOrDefaultAsync(id) ?? throw new NotFoundException();
        await _countryRepository.DeleteAsync(data);
        return RedirectToAction(nameof(Index));
    }
}
