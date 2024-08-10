using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tactsoft.Application.Interfaces.Entities;
using Tactsoft.Application.ViewModels.VmEntities;

namespace Tactsoft.Web.Areas.Admin.Controllers
{
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
        public ActionResult Create(StudentVm model)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
