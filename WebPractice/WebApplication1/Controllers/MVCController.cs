using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MVCController : Controller
    {
        // GET: MVC
        public ActionResult Index()
        {
            ViewData["A"] = "測試ViewData傳輸資料到前端";
            ViewBag.B = "測試ViewBag傳輸資料到前端";
            TempData["C"] = "測試TempData傳輸資料到前端";
            return View();
        }
    }
}