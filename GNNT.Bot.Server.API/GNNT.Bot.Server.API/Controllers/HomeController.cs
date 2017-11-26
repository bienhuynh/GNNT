using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GNNT.Bot.Server.API.Controllers
{
    public class HomeController : Controller
    {
        private AskPlacesController askPlace = new AskPlacesController();
        
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            
            return View();
        }
        public ActionResult Init()
        {
            ViewBag.Title = "Init Chat bot";
            askPlace.Post();

            return View();
        }

    }
}
