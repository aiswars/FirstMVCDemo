using FirstMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCDemo.Controllers
{
    public class HomController : Controller
    {
        // GET: Hom

        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
            Employee employee = employeeBL.GetEmployeeDetails(102);
            ViewData["Employee"] = employee;
            ViewData["Header"] = "Employee Details";
            return View();
        }

    }
}