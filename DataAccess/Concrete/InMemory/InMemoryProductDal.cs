using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Product { ProductID =1, CategoryID= 2,ProductName="Bardak", UnitPrice=15,UnitsInStock =15 },
                new Product { ProductID =2, CategoryID= 1,ProductName="Kamera", UnitPrice=130,UnitsInStock =14 },
                new Product { ProductID =3, CategoryID= 1,ProductName="Telefon", UnitPrice=1500,UnitsInStock =1 },
                new Product { ProductID =4, CategoryID= 1,ProductName="Klavye", UnitPrice=150,UnitsInStock =155 },
                new Product { ProductID =5, CategoryID= 2,ProductName="Demlik", UnitPrice=85,UnitsInStock =150 }
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

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            return _products.Where(p => p.CategoryID == categoryID).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            // Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
