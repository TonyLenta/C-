using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCL
{
    public class Repositorio

    {
        //creamos un metodo que devuelve el precio del listado
        public Producto GetProductByID(int ID)
        {
            //var Context = new NorthwindEntities();
            return Products.FirstOrDefault(p => p.ProductID == ID);
        }
        List<Producto> Products = new List<Producto>
        {
            new Producto
            {
                ProductID=1,ProductName="Sal",
                UnitPrice=20,UnitsInStock=20
            },
            new Producto
            {
                ProductID=2,ProductName="Aceite",
                UnitPrice=150,UnitsInStock=30
            },
            new Producto
            {
                ProductID=3,ProductName="mazanas",
                UnitPrice=1,UnitsInStock=20
            },
            new Producto
            {
                ProductID=4,ProductName="Laptop",
                UnitPrice=1250,UnitsInStock=3
            },
            new Producto
            {
                ProductID=5,ProductName="Perfume",
                UnitPrice=35,UnitsInStock=15
            },
        };

    }

}
