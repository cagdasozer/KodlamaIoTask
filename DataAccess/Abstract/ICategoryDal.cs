using KodlamaİoTask.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİoTask.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        Category GetById(int id);

        void Add(Category category);
        void Update(Category category);
    }
}
