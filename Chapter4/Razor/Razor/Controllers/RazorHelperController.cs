using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;


namespace Razor.Controllers
{
    public class RazorHelperController : Controller
    {
        // GET: RazorHelper
        public ActionResult Index()
        {
            return View();
        }
        //學生考試成績model
        protected List<Student> students = new List<Student>
        {
            new Student { Id = 1,Name = "Joe",Chinese = 88,English=95,Math=71},
            new Student { Id = 12,Name = "Mary",Chinese = 92,English=82,Math=60},
            new Student { Id = 23,Name = "Cathy",Chinese = 98,English=91,Math=94},
            new Student { Id = 34,Name = "John",Chinese = 63,English=85,Math=55},
            new Student { Id = 45,Name = "David",Chinese = 59,English=77,Math=82}
        };
        public ActionResult Scores()
        {
            return View(students);
        }
        public ActionResult ScoresRazorHelper()
        {
            //找出總分最高者之Id
            int topId = 0;
            int topscore = 0;

            foreach (var stu in students)
            {
                stu.Total = stu.Chinese + stu.English + stu.Math;
                if (topscore < stu.Total)
                {
                    topId = stu.Id;
                    topscore = stu.Total;
                }
            }
            //將最高分學生Id儲存到ViewBag，傳遞給View
            ViewBag.TopId = Convert.ToInt32(topId);
            return View(students);
        }
    }
}