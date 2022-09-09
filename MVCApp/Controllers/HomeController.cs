using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
using DataLibrary;
using static DataLibrary.BusinessLogic.EmployeeProcessor;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee Sign Up";

            return View();
        }
        public ActionResult ViewEmployee()
        {
            ViewBag.Message = "Employee List";

            var data = LoadEmployee();

            List<EmployeeModel> employee = new List<EmployeeModel>();

            foreach (var row in data)
            {
                employee.Add(new EmployeeModel
                {
                    EmployeeId = row.EmployeeId,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    EmailAddress = row.EmailAddress,
                    ConformEmail = row.EmailAddress
                });
            }

            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int recondCreated = CreateEmployee(
                    model.EmployeeId,
                    model.FirstName, 
                    model.LastName, 
                    model.EmailAddress
                               );
                return RedirectToAction("Index");
            }
            return View(); 
        }
    }
}