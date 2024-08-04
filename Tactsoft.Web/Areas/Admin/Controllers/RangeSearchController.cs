using Microsoft.AspNetCore.Mvc;

namespace Tactsoft.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RangeSearchController : Controller
    {
        // GET: RangeSearchController
        public ActionResult Index() { return View(); }

        // GET: RangeSearchController/Details/5
        public ActionResult Details(int id) { return View(); }

        // GET: RangeSearchController/Create
        public ActionResult Create() { return View(); }

        // POST: RangeSearchController/Create
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

        // GET: RangeSearchController/Edit/5
        public ActionResult Edit(int id) { return View(); }

        // POST: RangeSearchController/Edit/5
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

        // GET: RangeSearchController/Delete/5
        public ActionResult Delete(int id) { return View(); }

        // POST: RangeSearchController/Delete/5
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
