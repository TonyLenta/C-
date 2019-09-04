using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Demo_Modelo_Ncapas.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto

        //creamos un metodo de accion result details
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