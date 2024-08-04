using Microsoft.AspNetCore.Mvc;

namespace Tactsoft.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TabControlController : Controller
    {
        // GET: TabControlController
        public ActionResult Index() { return View(); }

        // GET: TabControlController/Details/5
        public ActionResult Details(int id) { return View(); }

        // GET: TabControlController/Create
        public ActionResult Create() { return View(); }

        // POST: TabControlController/Create
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

        // GET: TabControlController/Edit/5
        public ActionResult Edit(int id) { return View(); }

        // POST: TabControlController/Edit/5
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

        // GET: TabControlController/Delete/5
        public ActionResult Delete(int id) { return View(); }

        // POST: TabControlController/Delete/5
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
