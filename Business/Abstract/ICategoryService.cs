using KodlamaİoTask.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİoTask.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        void Add(Category category);
        void Update(Category category);
    }
}
