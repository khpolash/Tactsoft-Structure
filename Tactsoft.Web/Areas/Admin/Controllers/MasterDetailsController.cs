using Microsoft.AspNetCore.Mvc;

namespace Tactsoft.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MasterDetailsController : Controller
    {
        // GET: MasterDetailsController
        public ActionResult Index() { return View(); }

        // GET: MasterDetailsController/Details/5
        public ActionResult Details(int id) { return View(); }

        // GET: MasterDetailsController/Create
        public ActionResult Create() { return View(); }

        // POST: MasterDetailsController/Create
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

        // GET: MasterDetailsController/Edit/5
        public ActionResult Edit(int id) { return View(); }

        // POST: MasterDetailsController/Edit/5
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

        // GET: MasterDetailsController/Delete/5
        public ActionResult Delete(int id) { return View(); }

        // POST: MasterDetailsController/Delete/5
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
