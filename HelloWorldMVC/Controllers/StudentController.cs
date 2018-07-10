using HelloWorldMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class StudentController : Controller
    {
        //When the user navigates to a url (HttpGet)
        //When Student/Index is found in the route          // the form default submits to a post with the same name
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        //HttpPost  // This will get called after a user submits a HttpForm
        [HttpPost]
        public ActionResult Index(FormCollection data)
        {
            //Validate all form data

            //encapsulate form data in an object   
            Student stu = new Student
            {
                StudentId = data["txtSID"],
                FirstName = data["txtFName"],
                LastName = data["txtLName"],
                DateOfBirth = Convert.ToDateTime(data["txtDOB"])
            };
            //if everything is valid, add to database
            if (StudentDB.AddStudent(stu))
            {
                //ViewBag data only works for the current request
                ViewBag.StudentAdded = true;
            }
            //let the user know it was successful
            //Or display error messages

            return View();
        }
    }
}