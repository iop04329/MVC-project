using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Chapter8
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //路由會忽略掉WebResource.axd或ScriptResource.axd之類的請求，
            //不會將這類請求傳給Controller處理
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //1.Car
            routes.MapRoute(
                name: "Car",
                url: "Car",
                defaults: new { controller = "Automobile", action = "Index" }
            );

            //2.Car/Brand/{brand}
            routes.MapRoute(
                name: "FindCarByBrand",
                url: "Car/Brand/{brand}",
                defaults: new { controller = "Automobile", action = "FindBrand", brand = UrlParameter.Optional }
            );

            //3.Car/Category/{cat}
            routes.MapRoute(
                name: "CarCategory",
                url: "Car/Category/{cat}",
                defaults: new { controller = "Automobile", action = "FindCategory", cat = "轎車" }
            );

            //4.Car/Id/{id}
            routes.MapRoute(
                name: "FindCarById",
                url: "Car/Id/{id}",
                defaults: new { controller = "Automobile", action = "FindId", id = UrlParameter.Optional }
            );

            //5.Car/Year/{year}
            routes.MapRoute(
                name: "FindCarByYear",
                url: "Car/Year/{year}",
                defaults: new { controller = "Automobile", action = "FindYear", year = 2017 },
                constraints: new { year = @"\d{4}" }
            );

            //6.Car/Brand-Year/{brand}-{year}
            routes.MapRoute(
                name: "FindCarByBrandYear",
                url: "Car/Brand-Year/{brand}-{year}",
                defaults: new { controller = "Automobile", action = "FindBrandYear" },
                constraints: new { brand = @"\w+", year = @"\d{4}" }
            );

            //路由6可替換如下
            routes.MapRoute(
                name: "FindCarByBrandYear2",
                url: "Car/BrandYear/{brand}={year}",
                defaults: new { controller = "Automobile", action = "FindBrandYear" },
                constraints: new { brand = @"\w+", year = @"\d{4}" }
            );

            //7.Car/TopSales/{topnumber}
            routes.MapRoute(
                name: "CarTopSales",
                url: "Car/TopSales/{topnumber}",
                defaults: new { controller = "Automobile", action = "TopSales", topnumber = 5 },
                constraints: new { topnumber = @"[1-9]+[0-9]*" }
            );

            routes.MapRoute(
                name: "GetRouteData",
                url: "Car/Route/{RouteParam}",
                defaults: new { controller = "Automobile", action = "GetRouteData", RouteParam = UrlParameter.Optional }
            );

            //系統內建的一筆路由定義，其名稱為Default，名稱必須是唯一,否則會產生衝突
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
