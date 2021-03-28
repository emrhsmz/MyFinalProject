using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            // Oracle, SqlServer, Mysql,MongoDb,Postgress
            _products = new List<Product>() {
                new Product { ProductID =1, CategoryID= 2,ProductName="Bardak", UnitPrice=15,UnitInStock =15 },
                new Product { ProductID =2, CategoryID= 1,ProductName="Kamera", UnitPrice=130,UnitInStock =14 },
                new Product { ProductID =3, CategoryID= 1,ProductName="Telefon", UnitPrice=1500,UnitInStock =1 },
                new Product { ProductID =4, CategoryID= 1,ProductName="Klavye", UnitPrice=150,UnitInStock =155 },
                new Product { ProductID =5, CategoryID= 2,ProductName="Demlik", UnitPrice=85,UnitInStock =150 }
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ = Language Integrated Query
            //Lambda
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductID == product.ProductID);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            return _products.Where(p => p.CategoryID == categoryID).ToList();
        }

        public void Update(Product product)
        {
            // Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }
    }
}
