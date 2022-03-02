﻿using System;
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
    }
}