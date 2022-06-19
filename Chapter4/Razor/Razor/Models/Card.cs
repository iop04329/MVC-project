using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Razor.Models
{
    public class Card
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Brief { get; set; }
        public string Photo { get; set; }
        public string WikiUrl { get; set; }

    }
}