using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCDemo.Models
{

    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int EmployeeId)
        {
            //Here we hardcoded the data
            //later we will discuss how to retrieve
            //the data from a database
            Employee employee = new Employee()
            {
                EmployeeId = EmployeeId,  // 101 -- Employee employee = employeeBL.GetEmployeeDetails(101);
                Name = "Aish",
                Gender = "Female",
              //  City = "Bengaluru",
                Salary = 1000,
             //   Address = "KA"
            };
            return employee;
        }
    }


}