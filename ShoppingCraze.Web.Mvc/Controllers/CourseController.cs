using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCraze.Entities;
using ShoppingCraze.Service.Interfaces;
using ShoppingCraze.Web.Mvc.Filters;

namespace ShoppingCraze.Web.Mvc.Controllers
{
    [BasicAuthentication]
    public class CourseController : Controller
    {
        private ICourseService _service;

        public CourseController(ICourseService service)
        {
            _service = service;
        }

        [HttpGet]
        [BasicAuthentication]
        public ActionResult Index()
        {
            return View(_service.GetAll());
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(_service.GetById(id));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            try
            {
                // TODO: Add insert logic here
                //_service.Add(course);
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                return View(course);
            }
            catch
            {
                return View(course);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_service.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            try
            {
                // TODO: Add update logic here
                _service.Edit(course);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View(_service.GetById(id));
        }
        
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _service.Remove(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
