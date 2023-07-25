using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
           new Product{CategoryID = 1 , ProductID=1 , ProductName="Bardak",UnitPrice=15,UnitsInStock=15}
,           new Product{CategoryID = 2 , ProductID=2 , ProductName="Kamera",UnitPrice=150,UnitsInStock=3}
,           new Product{CategoryID = 3 , ProductID=3 , ProductName="Telefon",UnitPrice=1500,UnitsInStock=2}
,           new Product{CategoryID = 4 , ProductID=4 , ProductName="Klavye",UnitPrice=150,UnitsInStock=65}
,           new Product{CategoryID = 5 , ProductID=5 , ProductName="Fare",UnitPrice=85,UnitsInStock=1}

            };
        }
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
         Product ProductToDelete = null;
            /*
               foreach (Product p in _products)
               {
                if (product.ProductID == p.ProductID)
               {
                ProductToDelete = p;    
               }
               }
              */
            ProductToDelete = _products.SingleOrDefault(p=>p.ProductID==product.ProductID);
            _products.Remove(ProductToDelete);
        }

        public List<Product> GetAll()
        {
           return _products;
        }

        public List<Product> GetAllByCategory(int CategoryID)
        {
         return  _products.Where(p=>p.CategoryID == CategoryID).ToList();
        }

        public void Update(Product product)
        {
 
         Product ProductToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
           ProductToUpdate.ProductName = product.ProductName;
            ProductToUpdate.UnitPrice = product.UnitPrice;
            ProductToUpdate.UnitsInStock = product.UnitsInStock;
            ProductToUpdate.CategoryID = product.CategoryID;
        }
    }
}
