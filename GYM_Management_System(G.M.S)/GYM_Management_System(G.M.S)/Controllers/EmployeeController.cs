using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYM_Management_System_G.M.S_.Controllers
{
    public class EmployeeController : Controller
    {
        Models.gym_managementEntities1 db = new Models.gym_managementEntities1();
        // GET: Employee
        public ActionResult EmployeeRegistration() 
        {
            return View(db.Employees.ToList());
        }

        
        public ActionResult EmployeeInformation()
        {
            return View();
        }

        public ActionResult Designation()
        {
            return View();
        }
    }
}