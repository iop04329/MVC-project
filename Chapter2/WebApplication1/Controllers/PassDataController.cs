using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }
        //Chapter 2-19
        public ActionResult PetShop()
        {
            ViewData["Company"] = "汪星人寵物店";
            ViewBag.Address = "台北市信義區松山路100號";
            List<string> petList = new List<string>();
            petList.Add("狗");
            petList.Add("貓");
            petList.Add("魚");
            petList.Add("鼠");
            petList.Add("變色豬");

            //二選一
            //ViewData.Model = petList;
            //return View();
            return View(petList);
        }
    }
}