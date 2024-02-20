using KodlamaİoTask.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİoTask.DataAccess.Abstract
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        Course GetById(int id);

        void Add(Course course);
        void Remove(Course course);
        void Update(Course course);
    }
}
