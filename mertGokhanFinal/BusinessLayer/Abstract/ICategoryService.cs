using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<category> GetCategories();
        category GetCategoriesById(int id);
        category CreateCategory(category _category);
        category UpdateCategory(category _category);
        void DeleteCategory(int id);
    }
}
