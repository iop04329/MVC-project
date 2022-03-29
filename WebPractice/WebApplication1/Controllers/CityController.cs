using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication1.Models;
using PagedList;
using WebApplication1.Models;

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

        //ASP NET MVC導讀系列 LINQ查詢運算式
        //網址為:https://localhost:44336/City/ShowArrayAsc
        public string ShowArrayAsc()
        {
            int[] score = new int[] { 47, 39, 100, 98, 77 };
            var result = from m in score
                         orderby m ascending
                         select m;
            string show = "遞增排序 :";
            foreach(var m in result)
            {
                show += m + ",";
            }
            show += "<br>";
            show += "總合:" + result.Sum();
            return show;
        }
        //網址為:https://localhost:44336/City/ShowProduct
        public string ShowProduct()
        {
            Product[] p = new Product[]
            {
                new Product(){編號="G01",品名="火影忍者",單價=560},
                new Product(){編號="G02",品名="航海王",單價=60},
                new Product(){編號="G03",品名="七龍珠",單價=180}
            };
            var result = from m in p
                         where m.單價 >= 300
                         orderby m.單價 descending
                         select m;
            string show = "";
            foreach(var item in result)
            {
                show += string.Format("<p>{0},{1},{2}</p>", item.編號, item.品名, item.單價);
            }
            return show;
        }

        //ASP NET MVC導讀系列 HTML Helper
        //網址為:https://www.youtube.com/watch?v=AaZOHBgKvUk&list=PLygCabSM5MspocL_cCQtf27E3aYojmdgn&index=9
        public ActionResult HTMLHelper()
        {
            return View();
        }
    }
}