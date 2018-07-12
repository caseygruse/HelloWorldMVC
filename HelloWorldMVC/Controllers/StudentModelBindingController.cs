using HelloWorldMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class StudentModelBindingController : Controller
    {
        // GET: StudentModelBinding/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Student stu)
        {
            //this ensures all validation rules for the model have passed.
            if (ModelState.IsValid)
            {
                if (StudentDB.AddStudent(stu))
                {
                    ViewBag.Added = true;
                }
            }

            return View();
        }
    }
}