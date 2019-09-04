using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Repositorio
    {
        public Demo GetDemo()
        {
            return new Demo { Mensaje = "hola mundo", mensajeHtml = "<h1>hola mundo" };
        }
    }
}