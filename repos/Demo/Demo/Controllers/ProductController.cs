using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var Repository = new ModelCL.Repositorio();
            var Model = Repository.GetProducts();
            return View(Model);
           // return View("Hola producto");
        }


        //desde aqui se eejecuta
        public ActionResult Details(int id)
        {
            ActionResult Result = null;
            var Repository = new ModelCL.Repositorio();
            var Model = Repository.GetProductByID(id);
            if (Model != null)
            {
                // Result = Content(Model.ProductName);
                //Result = View(Model);
                Result = View("Details2", Model);
            }
            else
            {
                Result = Content("Producto no encontrado");
            }
            return Result;
        }
    }
}