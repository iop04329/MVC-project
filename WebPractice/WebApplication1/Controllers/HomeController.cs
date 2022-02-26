using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        dbToDoEntities db = new dbToDoEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tsai()
        {
            var todos = db.tToDo.OrderByDescending(m => m.fDate).ToList();
            return View(todos);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string fTitle,string fimage,DateTime fDate)
        {
            tToDo todo = new tToDo();
            todo.ftitle = fTitle;
            todo.fimage = fimage;
            todo.fDate = fDate;
            db.tToDo.Add(todo);
            db.SaveChanges();
            return RedirectToAction("Tsai");
        }

        public ActionResult Delete(int id)
        {
            var todo = db.tToDo.Where(m => m.fid == id).FirstOrDefault();
            db.tToDo.Remove(todo);
            db.SaveChanges();
            return RedirectToAction("Tsai");
        }

        public ActionResult Edit(int id)
        {
            var todo = db.tToDo.Where(m => m.fid == id).FirstOrDefault();

            return View(todo);
        }
        [HttpPost]
        public ActionResult Edit(int fid,string fTitle, string fimage, DateTime fDate)
        {
            var todo = db.tToDo.Where(m => m.fid == fid).FirstOrDefault();
            todo.ftitle = fTitle;
            todo.fimage = fimage;
            todo.fDate = fDate;
            db.SaveChanges();
            return RedirectToAction("Tsai");
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
    }
}