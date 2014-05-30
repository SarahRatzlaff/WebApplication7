using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        
        
        public ActionResult Index()
        {

            Message some = new Message();
            Singleton.Instance.data.Add("Hi");

            some.messageList = Singleton.Instance.data;

            return View(some.messageList);
        }
       
        [HttpPost]
        public ActionResult Message(string From, string To, string Body)
        {
            Singleton.Instance.data.Add(Body);

           

            return RedirectToAction("Index");
           
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}