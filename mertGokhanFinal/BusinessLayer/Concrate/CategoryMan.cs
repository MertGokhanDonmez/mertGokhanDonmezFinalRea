using BusinessLayer.Abstract;
using DataAccess;
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
    public class CategoryMan : ICategoryService
    {
        private ICategoryRepo _catDal;
        public CategoryMan()
        {
            _catDal = new CategoryRepo();
        }

        public category CreateCategory(category _category)
        {
            return _catDal.CreateCategory(_category);
        }

        public void DeleteCategory(int id)
        {
            _catDal.DeleteCategory(id);
        }

        public List<category> GetCategories()
        {
            return _catDal.GetCategories();
        }

        public category GetCategoriesById(int id)
        {
            if (id > 0)
            {
                return _catDal.GetCategoriesById(id);
            }
            throw new Exception("ID 1 in altinda olamaz!!!");
        }

        public category UpdateCategory(category _category)
        {
            return _catDal.UpdateCategory(_category);
        }
    }
}
