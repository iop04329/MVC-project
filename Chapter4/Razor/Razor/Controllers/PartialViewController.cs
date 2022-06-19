using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialView
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SimpleCard()
        {
            return View();
        }
        public ActionResult ManCard()
        {
            List<Card> cards = new List<Card>
            {
                new Card{Name = "Elon Musk",Brief="Tesla創辦人 伊隆˙馬斯克",Photo="ElonMusk.jpg", WikiUrl="https://zh.m.wikipedia.org/zh-tw/埃隆·马斯克"},
                new Card{Name = "Mark Zuckerberg",Brief="Facebook創辦人 伊隆˙馬斯克",Photo="MarkZuckerberg.jpg", WikiUrl="https://zh.m.wikipedia.org/zh-tw/马克·扎克伯格"},
                new Card{Name = "Steve Jobs",Brief="Apple創辦人 伊隆˙馬斯克",Photo="SteveJobs.jpg", WikiUrl="https://zh.m.wikipedia.org/zh-tw/史蒂夫·乔布斯"},
                new Card{Name = "Darth Vader",Brief="帝國元帥 維達",Photo="Vador.jpg", WikiUrl="https://zh.m.wikipedia.org/zh-tw/Darth_Vader"},
                new Card{Name = "Darth Mual",Brief="星際大戰 達斯摩",Photo="Maul.jpg", WikiUrl="https://zh.m.wikipedia.org/zh-tw/達斯·魔"},
                new Card{Name = "White Twilek",Brief="星際大戰 女絕地武士Twilek",Photo="Twilek.jpg", WikiUrl="https://starwars.fandom.com/wiki/Twi%27lek"}
            };
            return View(cards);
        }
    }
}