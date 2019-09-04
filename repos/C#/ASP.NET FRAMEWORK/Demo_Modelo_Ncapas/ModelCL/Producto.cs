using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCL
{
    public class Producto
    {

        //Atributos que vamos a utilizar para el ingreso a la base de datos
        public int ProductID { get; set; }
        public string  ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
