using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiService.Models;
using WebApiService.Helpers;

namespace WebApiService.Controllers
{
    public class TCarsController : ApiController
    {
        //注意 控制器名稱與URL有關 Cars -> TCars
        List<CarSales> CarSalesNumber;
        public TCarsController()
        {
            //以亂數產生1-12月銷售數據
            Utility util = new Utility();
            var random1 = util.getNumbers(12);
            var random2 = util.getNumbers(12);

            CarSalesNumber = new List<CarSales>
            {
                new CarSales { Id = 1, Car = "BMW", Salesdata = random1 },
                new CarSales { Id = 2, Car = "BENZ", Salesdata = random2 }
            };
        }

        //URL api/cars
        //回傳所有汽車的銷售資料
        [AcceptVerbs("GET", "POST")]
        public IEnumerable<CarSales> getCarSalesNumber()
        {
            return CarSalesNumber;
        }

        //URL api/cars/2
        //根據汽車Id找出銷售資料
        [AcceptVerbs("GET", "POST")]
        public IHttpActionResult getSingleCarSalesNumber(int id)
        {
            var car = CarSalesNumber.FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            var result = Ok(car);
            return result;
        }
    }
}
