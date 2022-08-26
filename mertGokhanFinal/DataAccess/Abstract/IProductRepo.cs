using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductRepo
    {
        List<product> GetProducts();
        product GetProductsById(int id);
        product CreateProduct(product _product);
        product UpdateProduct(product _product);
        void DeleteProduct(int id);
    }
}
