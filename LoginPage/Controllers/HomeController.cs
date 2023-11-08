using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using LoginPage.Models;


namespace LoginPage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       loginEntities1 db =new loginEntities1();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(users log)
        {

            var user =db.users.Where(x => x.Username == log.Username && x.Password == log.Password).Count();
            if(user>0) 
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();

            }
        
        }
        public ActionResult Dashboard() 
        {
            return View(); 
        
        }
    }
}