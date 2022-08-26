using BusinessLayer.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrate;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class ProductMan : IProductService
    {
        private IProductRepo _proDal;
        public ProductMan()
        {
            _proDal = new ProductRepo();
        }
        public product CreateProduct(product _product)
        {
            return _proDal.CreateProduct(_product);
        }

        public void DeleteProduct(int id)
        {
            _proDal.DeleteProduct(id);
        }

        public List<product> GetProducts()
        {
            return _proDal.GetProducts();
        }

        public product GetProductsById(int id)
        {
            if (id > 0)
            {
                return _proDal.GetProductsById(id);
            }
            throw new Exception("ID 1 in altinda olamaz!!!");
        }

        public product UpdateProduct(product _product)
        {
            return _proDal.UpdateProduct(_product);
        }
    }
}
