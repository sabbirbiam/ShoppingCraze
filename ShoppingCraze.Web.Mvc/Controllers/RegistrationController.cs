using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCraze.Entities;
using ShoppingCraze.Service.Interfaces;

namespace ShoppingCraze.Web.Mvc.Controllers
{
    public class RegistrationController : Controller
    {
        private IRegistrationService _service;

        public RegistrationController(IRegistrationService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult Register(Registration reg)
        {
            _service.Add(reg);
            return View();
        }

        [HttpGet]
        public ActionResult UnRegister(Registration reg)
        {
            reg = _service.GetByStudentIdAndSectionId(reg.StudentId, reg.SectionId);
            _service.Remove(reg.Id);            
            return View();
        }
    }
}