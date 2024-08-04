using Microsoft.AspNetCore.Mvc;

namespace Tactsoft.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CascadingSearchController : Controller
    {
        // GET: CascadingSearchController
        public ActionResult Index() { return View(); }

        // GET: CascadingSearchController/Details/5
        public ActionResult Details(int id) { return View(); }

        // GET: CascadingSearchController/Create
        public ActionResult Create() { return View(); }

        // POST: CascadingSearchController/Create
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

        // GET: CascadingSearchController/Edit/5
        public ActionResult Edit(int id) { return View(); }

        // POST: CascadingSearchController/Edit/5
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

        // GET: CascadingSearchController/Delete/5
        public ActionResult Delete(int id) { return View(); }

        // POST: CascadingSearchController/Delete/5
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
