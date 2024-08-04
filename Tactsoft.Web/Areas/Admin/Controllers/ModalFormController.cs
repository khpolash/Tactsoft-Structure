using Microsoft.AspNetCore.Mvc;

namespace Tactsoft.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ModalFormController : Controller
    {
        // GET: ModalFormController
        public ActionResult Index() { return View(); }

        // GET: ModalFormController/Details/5
        public ActionResult Details(int id) { return View(); }

        // GET: ModalFormController/Create
        public ActionResult Create() { return View(); }

        // POST: ModalFormController/Create
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

        // GET: ModalFormController/Edit/5
        public ActionResult Edit(int id) { return View(); }

        // POST: ModalFormController/Edit/5
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

        // GET: ModalFormController/Delete/5
        public ActionResult Delete(int id) { return View(); }

        // POST: ModalFormController/Delete/5
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
