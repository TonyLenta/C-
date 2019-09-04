using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCL
{
    public class Repositorio
    {
        public Product GetProductByID(int ID)
        {
            //var Context = new NorthwindEntities();
            var Context = new NorthwindEntities1();
            return Products.FirstOrDefault(p => p.ProductID == ID);
        }

        //metodo
        public List<Product> GetProducts()
        {
            List<Product> Result = null;
            using (var Context = new NorthwindEntities1())
            {
                Result = Context.Products.ToList();
            }
            return Result;
        }

       

        List<Product> Products = new List<Product>
        {
            new Product
            {
                ProductID=1,ProductName="Sal",
                UnitPrice=20,UnitsInStock=20
            },
            new Product
            {
                ProductID=2,ProductName="Aceite",
                UnitPrice=150,UnitsInStock=30
            },
            new Product
            {
                ProductID=3,ProductName="Aceite",
                UnitPrice=150,UnitsInStock=30
            },
            new Product
            {
                ProductID=4,ProductName="Aceite",
                UnitPrice=150,UnitsInStock=30
            },
            new Product
            {
                ProductID=5,ProductName="Aceite",
                UnitPrice=150,UnitsInStock=30
            },


        };
    }
}
