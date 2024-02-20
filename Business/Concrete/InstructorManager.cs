using KodlamaİoTask.Business.Abstract;
using KodlamaİoTask.DataAccess.Abstract;
using KodlamaİoTask.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİoTask.Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _ınstructorDal;

        public InstructorManager(IInstructorDal ınstructorDal)
        {
            _ınstructorDal = ınstructorDal;
        }

        public void Add(Instructor ınstructor)
        {
            _ınstructorDal.Add(ınstructor);
        }

        public List<Instructor> GetAll()
        {
            return _ınstructorDal.GetAll();
        }

        public void Update(Instructor ınstructor)
        {
            _ınstructorDal.Update(ınstructor);
        }
    }
}
