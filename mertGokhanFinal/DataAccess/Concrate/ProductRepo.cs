using DataAccess.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class ProductRepo : IProductRepo
    {
        public product CreateProduct(product _product)
        {
            using (var productContextDb = new Context())
            {
                productContextDb.products.Add(_product);
                productContextDb.SaveChanges();
                return _product;
            }
        }

        public void DeleteProduct(int id)
        {
            using (var productContextDb = new Context())
            {
                var deleteProduct = GetProductsById(id);
                productContextDb.products.Remove(deleteProduct);
                productContextDb.SaveChanges();
            }
        }

        public List<product> GetProducts()
        {
            using (var productContextDb = new Context())
            {
                return productContextDb.products.ToList();
            }
        }

        public product GetProductsById(int id)
        {
            using (var productContextDb = new Context())
            {
                return productContextDb.products.Find(id);
            }
        }

        public product UpdateProduct(product _product)
        {
            using (var productContextDb = new Context())
            {
                productContextDb.products.Update(_product);
                productContextDb.SaveChanges();
                return _product;
            }
        }
    }
}
