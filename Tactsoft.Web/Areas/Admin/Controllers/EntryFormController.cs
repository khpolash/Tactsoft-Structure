using Microsoft.AspNetCore.Mvc;

namespace Tactsoft.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EntryFormController : Controller
    {
        // GET: EntryFormController
        public ActionResult Index() { return View(); }

        // GET: EntryFormController/Details/5
        public ActionResult Details(int id) { return View(); }

        // GET: EntryFormController/Create
        public ActionResult Create() { return View(); }

        // POST: EntryFormController/Create
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

        // GET: EntryFormController/Edit/5
        public ActionResult Edit(int id) { return View(); }

        // POST: EntryFormController/Edit/5
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

        // GET: EntryFormController/Delete/5
        public ActionResult Delete(int id) { return View(); }

        // POST: EntryFormController/Delete/5
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
