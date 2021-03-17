using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationFormMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormMVC.Controllers
{
    public class RegistrationFormController : Controller
    {
        // GET: RegistrationFormController
        public ActionResult Index(RegistrationModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            return View(model);
        }

        // GET: RegistrationFormController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegistrationFormController/Create
        public ActionResult Create()
        {
            
            return View();

        }

        // POST: RegistrationFormController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            var model = new RegistrationModel();
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistrationFormController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegistrationFormController/Edit/5
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

        // GET: RegistrationFormController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistrationFormController/Delete/5
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
