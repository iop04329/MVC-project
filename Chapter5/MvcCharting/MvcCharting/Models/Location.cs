using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCharting.Models
{
    public class Location
    {
        public string City { get; set; }    //城市名稱
        public double[] Temperature { get; set; }   //1-12月份溫度資料
    }
}