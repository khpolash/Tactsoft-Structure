using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SendGrid.Helpers.Errors.Model;
using Tactsoft.Application.Interfaces.Entities;
using Tactsoft.Application.ViewModels.VmEntities;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class StudentController : Controller
{
    private readonly IStudentRepository _studentRepository;
    private readonly ICountryRepository _countryRepository;
    private readonly IStateRepository _stateRepository;
    private readonly ICityRepository _cityRepository;
    private readonly IMapper _mapper;

    public StudentController(IStudentRepository studentRepository, ICountryRepository countryRepository, IStateRepository stateRepository, ICityRepository cityRepository, IMapper mapper)
    {
        _studentRepository = studentRepository;
        _countryRepository = countryRepository;
        _stateRepository = stateRepository;
        _cityRepository = cityRepository;
        _mapper = mapper;
    }

    // GET: StudentController
    public async Task<ActionResult> Index()
    {
        var students = await _studentRepository.GetAllAsync(x => x.Country, x => x.State, x => x.City);
        return View(_mapper.Map<List<StudentVm>>(students));
    }

    // GET: StudentController/Details/5
    public async Task<ActionResult> Details(int id)
    {
        var student = await _studentRepository.FirstOrDefaultAsync(id, x => x.Country, x => x.State, x => x.City);
        return View(_mapper.Map<StudentVm>(student));
    }

    // GET: StudentController/Create
    public async Task<ActionResult> Create()
    {
        var model = new StudentVm
        {
            CountryDropdown = await _countryRepository.GetDropdown(),
            StateDropdown = await _stateRepository.GetDropdown(),
            CityDropdown = await _cityRepository.GetDropdown(),
        };
        return View(model);
    }

    // POST: StudentController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create(StudentVm model)
    {
        if (ModelState.IsValid)
        {
            if (model.ProfilePhotoFile != null && model.ProfilePhotoFile.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/students",
                 model.ProfilePhotoFile.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    model.ProfilePhotoFile.CopyTo(stream);
                }
                model.ProfilePhoto = $"{model.ProfilePhotoFile.FileName}";
            }

            var entity = _mapper.Map<Student>(model);
            await _studentRepository.InsertAsync(entity);
            return RedirectToAction("Index");
        }
        model.CountryDropdown = await _countryRepository.GetDropdown();
        model.StateDropdown = await _stateRepository.GetDropdown();
        model.CityDropdown = await _cityRepository.GetDropdown();
        return View(model);
    }

    // GET: StudentController/Edit/5
    public async Task<ActionResult> Edit(long id)
    {
        var student = await _studentRepository.FirstOrDefaultAsync(id);
        var model = _mapper.Map<StudentVm>(student);
        model.CountryDropdown = await _countryRepository.GetDropdown(student.CountryId);
        model.StateDropdown = await _stateRepository.GetDropdown(student.StateId);
        model.CityDropdown = await _cityRepository.GetDropdown(student.CityId);
        return View(model);
    }

    // POST: StudentController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Edit(StudentVm model)
    {
        if (ModelState.IsValid)
        {
            if (model.ProfilePhotoFile != null && model.ProfilePhotoFile.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/students",
                 model.ProfilePhotoFile.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    model.ProfilePhotoFile.CopyTo(stream);
                }
                model.ProfilePhoto = $"{model.ProfilePhotoFile.FileName}";
            }

            var entity = _mapper.Map<Student>(model);
            await _studentRepository.UpdateAsync(entity);
            return RedirectToAction("Index");
        }
        model.CountryDropdown = await _countryRepository.GetDropdown(model.CountryId);
        model.StateDropdown = await _stateRepository.GetDropdown(model.StateId);
        model.CityDropdown = await _cityRepository.GetDropdown(model.CityId);
        return View(model);
    }

    // GET: StudentController/Delete/5
    public async Task<ActionResult> Delete(int id)
    {
        var data = await _studentRepository.FirstOrDefaultAsync(id, x => x.Country, x => x.State, x => x.City);
        return View(_mapper.Map<StudentVm>(data));
    }

    // POST: StudentController/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> DeleteConfirm(int id)
    {
        var data = await _studentRepository.FirstOrDefaultAsync(id);
        if (data == null)
            throw new NotFoundException();

        await _studentRepository.DeleteAsync(data);
        return RedirectToAction("Index");
    }


    public async Task<JsonResult> StatesByCountryId(long countryId)
    {
        return Json(await _stateRepository.StatesByCountry(countryId));
    }

    public async Task<JsonResult> CitiesByStateId(long stateId)
    {
        return Json(await _cityRepository.CitiesByState(stateId));
    }
}
