using KodlamaİoTask.DataAccess.Abstract;
using KodlamaİoTask.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİoTask.DataAccess.Concrete
{
    public class EfCategoryRepository : ICategoryDal
    {

        List<Category> categories;

        public EfCategoryRepository()
        {
            Category category1 = new Category();
            {
                category1.CategoryId = 1;
                category1.CategoryName = "Programlama";
            }

            categories = new List<Category> {category1};
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            return categories.FirstOrDefault(category => category.CategoryId == id);
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            categoryToUpdate.CategoryName = category.CategoryName;
        }
    }
}
