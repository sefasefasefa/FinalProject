using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _IProductDal;

        public ProductManager(IProductDal ıProductDal)
        {
            _IProductDal = ıProductDal;
        }

        public List<Product> GetAll()
        {
            //iş Kodları
            return _IProductDal.GetAll();
        }
    }
}
