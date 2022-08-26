using DataAccess.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class CategoryRepo : ICategoryRepo
    {
        public category CreateCategory(category _category)
        {
            using (var categoryContextDb = new Context())
            {
                categoryContextDb.categories.Add(_category);
                categoryContextDb.SaveChanges();
                return _category;
            }
        }

        public void DeleteCategory(int id)
        {
            using (var categoryContextDb = new Context())
            {
                var deleteCategory = GetCategoriesById(id);
                categoryContextDb.categories.Remove(deleteCategory);
                categoryContextDb.SaveChanges();
            }
        }

        public List<category> GetCategories()
        {
            using (var categoryContextDb = new Context())
            {
                return categoryContextDb.categories.ToList();
            }
        }

        public category GetCategoriesById(int id)
        {
            using (var categoryContextDb = new Context())
            {
                return categoryContextDb.categories.Find(id);
            }
        }

        public category UpdateCategory(category _category)
        {
            using (var categoryContextDb = new Context())
            {
                categoryContextDb.categories.Update(_category);
                categoryContextDb.SaveChanges();
                return _category;
            }
        }
    }
}
