using KodlamaİoTask.Business.Concrete;
using KodlamaİoTask.DataAccess.Concrete;
using KodlamaİoTask.Entities.Concrete;

namespace KodlamaİoTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(" ");

            CourseManager courseManager = new CourseManager(new EfCourseRepository());
            List<Course> courses = courseManager.GetAll();

            Console.WriteLine("---KURS BİLGİLERİ---");
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine(courses[i].CategoryId + " nolu Kategori" + " / " + courses[i].CourseName + " / " + courses[i].CourseDescription + " / ");
            }

            Console.WriteLine(" ");

            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
            List<Category> categories = categoryManager.GetAll();

            Console.WriteLine("---KATEGORİ İSİMLERİ---");
            foreach (var category in categories)
            {
                Console.WriteLine("Kategori Numarası:" + category.CategoryId + " ->" + category.CategoryName);
            }

            Console.WriteLine(" ");


            InstructorManager ınstructorManager = new InstructorManager(new EfInstructorRepository());
            List<Instructor> ınstructors = ınstructorManager.GetAll();

            Console.WriteLine("---EĞİTMENLER---");
            foreach (var ınstructor in ınstructors)
            {
                Console.WriteLine("Eğitmen Numarası:" + ınstructor.InstructorId);
                Console.WriteLine("Eğitmen Adı: " + ınstructor.InstructorName);
            }
        }
    }
}
