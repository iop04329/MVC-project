using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //2-25
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmployeeList()
        {
            //Using Models裡面的Employee 類別
            List<Employee> emp = new List<Employee>
            {
                new Employee {Id=10001,Name = "David",Phone="0933-154228",Email="david@gmail.com"},
                new Employee {Id=10002,Name = "Mary",Phone="0925-157886",Email="mary@gmail.com"},
                new Employee {Id=10003,Name = "John",Phone="0921-335884",Email="john@gmail.com"},
                new Employee {Id=10004,Name = "Cindy",Phone="0971-628322",Email="cindy@gmail.com"},
                new Employee {Id=10005,Name = "Rose",Phone="0933-154228",Email="rose@gmail.com"}
            };
            //傳入view
            return View(emp);
        }
    }
}