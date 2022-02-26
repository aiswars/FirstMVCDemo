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

        public ActionResult Index(int id)
        {
            EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
            Employee employee = employeeBL.GetEmployeeDetails(id);
            return View();
        }

    }
}