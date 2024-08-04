using Microsoft.AspNetCore.Mvc;

namespace Tactsoft.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MultipleWizardController : Controller
    {
        // GET: MultipleWizardController
        public ActionResult Index() { return View(); }

        // GET: MultipleWizardController/Details/5
        public ActionResult Details(int id) { return View(); }

        // GET: MultipleWizardController/Create
        public ActionResult Create() { return View(); }

        // POST: MultipleWizardController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            } catch
            {
                return View();
            }
        }

        // GET: MultipleWizardController/Edit/5
        public ActionResult Edit(int id) { return View(); }

        // POST: MultipleWizardController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            } catch
            {
                return View();
            }
        }

        // GET: MultipleWizardController/Delete/5
        public ActionResult Delete(int id) { return View(); }

        // POST: MultipleWizardController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            } catch
            {
                return View();
            }
        }
    }
}
