using Microsoft.AspNetCore.Mvc;

namespace Tactsoft.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MultiImageUploaderController : Controller
    {
        // GET: MultiImageUploaderController
        public ActionResult Index() { return View(); }

        // GET: MultiImageUploaderController/Details/5
        public ActionResult Details(int id) { return View(); }

        // GET: MultiImageUploaderController/Create
        public ActionResult Create() { return View(); }

        // POST: MultiImageUploaderController/Create
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

        // GET: MultiImageUploaderController/Edit/5
        public ActionResult Edit(int id) { return View(); }

        // POST: MultiImageUploaderController/Edit/5
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

        // GET: MultiImageUploaderController/Delete/5
        public ActionResult Delete(int id) { return View(); }

        // POST: MultiImageUploaderController/Delete/5
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
