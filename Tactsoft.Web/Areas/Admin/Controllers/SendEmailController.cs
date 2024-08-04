﻿using Microsoft.AspNetCore.Mvc;

namespace Tactsoft.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SendEmailController : Controller
    {
        // GET: SendEmailController
        public ActionResult Index() { return View(); }

        // GET: SendEmailController/Details/5
        public ActionResult Details(int id) { return View(); }

        // GET: SendEmailController/Create
        public ActionResult Create() { return View(); }

        // POST: SendEmailController/Create
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

        // GET: SendEmailController/Edit/5
        public ActionResult Edit(int id) { return View(); }

        // POST: SendEmailController/Edit/5
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

        // GET: SendEmailController/Delete/5
        public ActionResult Delete(int id) { return View(); }

        // POST: SendEmailController/Delete/5
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
