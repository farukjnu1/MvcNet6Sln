﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MvcNet6.Controllers
{
    public class PatientsController : Controller
    {
        // GET: PatientsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PatientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PatientsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientsController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.id = id;
            return View();
        }

        // POST: PatientsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PatientsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
