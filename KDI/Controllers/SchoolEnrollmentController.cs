using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KDI.Controllers
{
    public class SchoolEnrollmentController : Controller
    {
        // GET: SchoolEnrollment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Table()
        {
            return View();
        }

        // GET: SchoolEnrollment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SchoolEnrollment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchoolEnrollment/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SchoolEnrollment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SchoolEnrollment/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SchoolEnrollment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SchoolEnrollment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
