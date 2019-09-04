using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;



namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {

            Repositorio R = new Repositorio();
            var Model = R.GetDemo();
            return View(Model);
         //   return View();
           //return  Content("Prueba..");
           
        
        }
    }
}