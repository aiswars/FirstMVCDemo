using FirstMVCDemo.Models;
using FirstMVCDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ViewResult Details()
        {
            //Employee Basic Details
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                Name = "Daksh",
                Gender = "Male",
                Department = "IT",
                Salary = 15000,
                AddressId = 888
            };
            //Employee Address
            Address address = new Address()
            {
                AddressId = 888,
                City = "Kottayam",
                State = "Kerala",
                Country = "India",
                Pin = "2324234"
            };
            //Creating the View model
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = employee,
                Address = address,
                PageTitle = "Employee Details Page",
                PageHeader = "Employee Details",
            };
            //Pass the employeeDetailsViewModel to the view
            return View(employeeDetailsViewModel);
        }
    }
}