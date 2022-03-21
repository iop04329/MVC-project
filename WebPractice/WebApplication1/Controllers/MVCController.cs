using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace WebApplication1.Controllers
{
    public class MVCController : Controller
    {
        // GET: MVC
        public ActionResult Index()  // Lab Mis2000(最一開始) data傳輸練習
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

        #region 檔案上傳
        public ActionResult FileUpload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase photo)
        {
            //上傳圖檔
            string Filename = "";
            //檔案上傳
            if(photo != null)
            {
                if(photo.ContentLength > 0)
                {
                    //取得檔案名稱
                    Filename = Path.GetFileName(photo.FileName);
                    var path = Path.Combine(Server.MapPath("~/Photos"), Filename);
                    photo.SaveAs(path);
                }
            }
            return RedirectToAction("ShowPhotos");
        }
        //ShowPhotos方法可顯示Photos資料夾下所有圖檔
        public string ShowPhotos()
        {
            string show = "";

            //建立可操作Photos資料夾的dir物件
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/Photos"));
            //取得dir物件下的所有檔案(即Photos資料夾下)並放入finfo檔案資訊陣列
            FileInfo[] finfo = dir.GetFiles();
            int n = 0;
            //逐一將finfo檔案資訊陣列內的所有圖檔指定給show變數
            foreach(FileInfo result in finfo)
            {
                n++;
                //將目前取得的圖顯示在lblShow標籤內
                show += "<a href='../Photos/" + result.Name + "'target='_blank'><img src='../Photos/" + result.Name
                    + "'width='200' height='400' border='0'></a> ";
                if(n % 4 == 0) //每四個跳一行
                {
                    show += "<p>";
                }
            }
            //show變數再加上'返回' FileUpload動作方法的連結
            show += "<p><a href='FileUpload'>返回</a></p>";
            return show;
        }

        #endregion

    }
}