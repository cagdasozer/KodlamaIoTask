using KodlamaİoTask.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİoTask.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        Instructor GetById(int id);

        void Add(Instructor ınstructor);
        void Update(Instructor ınstructor);
        
    }
}
