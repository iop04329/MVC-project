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
        public ActionResult Index()  // data傳輸練習
        {
            ViewData["A"] = "測試ViewData傳輸資料到前端";
            ViewBag.B = "測試ViewBag傳輸資料到前端";
            TempData["C"] = "測試TempData傳輸資料到前端";
            return View();
        }
        public ActionResult Index2()  // 模型繫結
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index2(string PId,string PName,int Price)  // 模型繫結
        {
            ViewBag.PId = PId;
            ViewBag.PName = PName;
            ViewBag.Price = Price;
            return View();
        }

        public string ActionTest()  //練習控制器與動作方法
        {
            //return "OK";
            string show = "";
            for(int i = 0; i <= 3; i++)
            {
                if(i == 3)
                    show += string.Format("<img src ='../image/{0}.jpg' width='150'>", i);
                else
                    show += string.Format("<img src ='../image/{0}.png' width='150'>", i);
            }
            return show;
        }
        public string ShowImage(int index)  //練習控制器與動作方法 (帶入參數&帶入參數)
        {
            //return "OK";
            string []text = new string[] { "Book1","Book2","Book3","Poland"};
            string img = string.Format("<p align='center'><img src='../image/{0}.png'><br>{1}</p>", index, text[index]);
            
            return img;
        }
    }
}