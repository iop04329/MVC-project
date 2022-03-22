using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication1.Models;
using PagedList;

namespace WebApplication1.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        //ASP NET MVC導讀系列 Razor語法
        public ActionResult City()
        {
            string[] id = new string[] { "Brazil", "China", "England", "French", "India", "Malaysia", "New York", "Paris", "Russia", "Taipei", "Tokyo" };
            string[] name = new string[] { "巴西", "中國", "英國", "德國", "印度", "馬來西亞", "美國", "法國", "俄羅斯", "台灣", "日本" };
            string[] address = new string[] { "南美洲", "亞州", "歐洲", "歐洲", "亞州", "亞洲", "北美洲", "歐洲", "亞州", "亞州", "亞洲" };
            List<WorldwideCity> list = new List<WorldwideCity>();
            for (var i = 0; i < id.Length; i++)
            {
                WorldwideCity city = new WorldwideCity();
                city.Id = id[i];
                city.Name = name[i];
                city.Address = address[i];
                list.Add(city);
            }
            return View(list);
        }
        //ASP NET MVC導讀系列 資料分頁
        public ActionResult City2(int page = 1)
        {
            int pagesize = 3;
            int pagecurrent = page < 1 ? 1 : page;
            string[] id = new string[] { "Brazil", "China", "England", "French", "India", "Malaysia", "New York", "Paris", "Russia", "Taipei", "Tokyo" };
            string[] name = new string[] { "巴西", "中國", "英國", "德國", "印度", "馬來西亞", "美國", "法國", "俄羅斯", "台灣", "日本" };
            string[] address = new string[] { "南美洲", "亞州", "歐洲", "歐洲", "亞州", "亞洲", "北美洲", "歐洲", "亞州", "亞州", "亞洲" };
            List<WorldwideCity> list = new List<WorldwideCity>();
            for (var i = 0; i < id.Length; i++)
            {
                WorldwideCity city = new WorldwideCity();
                city.Id = id[i];
                city.Name = name[i];
                city.Address = address[i];
                list.Add(city);
            }
            var pageList = list.ToPagedList(pagecurrent, pagesize);
            return View(pageList);
        }
    }
}