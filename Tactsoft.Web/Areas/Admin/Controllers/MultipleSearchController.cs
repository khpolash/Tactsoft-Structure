using Microsoft.AspNetCore.Mvc;

namespace Tactsoft.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MultipleSearchController : Controller
    {
        // GET: MultipleSearchController
        public ActionResult Index() { return View(); }

        // GET: MultipleSearchController/Details/5
        public ActionResult Details(int id) { return View(); }

        // GET: MultipleSearchController/Create
        public ActionResult Create() { return View(); }

        // POST: MultipleSearchController/Create
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

        // GET: MultipleSearchController/Edit/5
        public ActionResult Edit(int id) { return View(); }

        // POST: MultipleSearchController/Edit/5
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

        // GET: MultipleSearchController/Delete/5
        public ActionResult Delete(int id) { return View(); }

        // POST: MultipleSearchController/Delete/5
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
