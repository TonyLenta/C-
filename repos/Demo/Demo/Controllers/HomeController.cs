using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Hola Mundo");
        }
        public ActionResult Details(int id)
        {
            ActionResult Result = null;
            var Repository = new ModelCL.Repositorio();
            var Model = Repository.GetProductByID(id);
            if (Model != null)
            {
                Result = Content(Model.ProductName);
                //Result = View(Model);
            }
            else
            {
                Result = Content("Producto no encontrado");
            }
            return Result;
        }
    }
}