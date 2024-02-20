using KodlamaİoTask.DataAccess.Abstract;
using KodlamaİoTask.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİoTask.DataAccess.Concrete
{
    public class EfInstructorRepository : IInstructorDal
    {
        List<Instructor> instructors;
        public EfInstructorRepository()
        {
            Instructor ınstructor1 = new Instructor();
            {
                ınstructor1.InstructorId = 1;
                ınstructor1.InstructorName = "Engin Demiroğ";
            }
            Instructor ınstructor2 = new Instructor();
            {
                ınstructor2.InstructorId = 2;
                ınstructor2.InstructorName = "Halit Enes Kalaycı";
            }

            instructors = new List<Instructor> {ınstructor1, ınstructor2 };
        }

        public void Add(Instructor ınstructor)
        {
            instructors.Add(ınstructor);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetById(int id)
        {
            return instructors.FirstOrDefault(ınstructor => ınstructor.InstructorId == id);
        }

        public void Update(Instructor ınstructor)
        {
            Instructor ınstructorToUpdate = instructors.SingleOrDefault(ı => ı.InstructorId == ınstructor.InstructorId);
            ınstructorToUpdate.InstructorName = ınstructor.InstructorName;
        }
    }
}
