using KodlamaİoTask.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİoTask.Business.Abstract
{
    public interface IInstructorService
    {
        List<Instructor> GetAll();

        void Add(Instructor ınstructor);
        void Update(Instructor ınstructor);
    }
}
