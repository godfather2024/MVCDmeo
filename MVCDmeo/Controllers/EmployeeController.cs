using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDmeo.Models;

namespace MVCDmeo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeContext empcontext = new EmployeeContext();
            List<Employee> emp = empcontext.Employees.ToList();

            return View(emp);
        }

        public ActionResult Details(int id)
        {

            EmployeeContext empcontext = new EmployeeContext();
            //List<Employee> emp = empcontext.Employees.ToList();
            Employee emp = empcontext.Employees.Single(x => x.EmpId == id);
            return View(emp);
        }
    }
}