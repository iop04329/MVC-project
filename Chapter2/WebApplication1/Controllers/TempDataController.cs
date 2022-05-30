using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        //2-22
        public ActionResult Index()
        {
            return View();
        }
        //TempData轉向其他Controller
        public ActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限存取系統資料,請聯絡系統管理員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongDateString();
            //轉向 (Action,Controller)
            return RedirectToAction("ErrorMessage", "TempData");
        }
        public ActionResult ErrorMessage()
        {
            if (!TempData.ContainsKey("ErrorMessage"))
            {
                return new EmptyResult();
            }
            TempData.Keep();
            //TempData.Keep("ErrorMessage");
            return View();
        }

    }
}