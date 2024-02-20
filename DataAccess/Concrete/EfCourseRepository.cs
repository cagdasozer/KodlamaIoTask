using KodlamaİoTask.DataAccess.Abstract;
using KodlamaİoTask.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİoTask.DataAccess.Concrete
{
    public class EfCourseRepository : ICourseDal
    {
        List<Course> courses;

        public EfCourseRepository()
        {
            Course course1 = new Course();
            {
                course1.Id = 1;
                course1.CourseName = "Senior Yazılım Yetiştirme Kampı(.NET)";
                course1.CourseDescription = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.";
                course1.CategoryId = 1;
                course1.InstructorId = 1;
            }

            Course course2 = new Course();
            {
                course2.Id = 2;
                course2.CourseName = "Yazılım Geliştirici Yetiştirme Kampı(C# + ANGULAR)";
                course2.CourseDescription = " ";
                course2.CategoryId = 1;
                course2.InstructorId = 1;
            }

            Course course3 = new Course();
            {
                course3.Id = 3;
                course3.CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
                course3.CourseDescription = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.";
                course3.CategoryId = 1;
                course3.InstructorId = 2;
            }

            Course course4 = new Course();
            {
                course4.Id = 4;
                course4.CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA";
                course4.CourseDescription = " ";
                course4.CategoryId = 1;
                course4.InstructorId = 1;
            }

            Course course5 = new Course();
            {
                course5.Id = 5;
                course5.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
                course5.CourseDescription = " ";
                course5.CategoryId = 1;
                course5.InstructorId = 1;

                courses = new List<Course> { course1, course2, course3, course4, course5 };
            }
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetById(int id)
        {
            return courses.FirstOrDefault(course => course.Id == id);
        }

        public void Remove(Course course)
        {
            Course courseToRemove = courses.SingleOrDefault(c => c.Id == course.Id);
            courses.Remove(courseToRemove);
        }

        public void Update(Course course)
        {
            Course courseToUpdate = courses.SingleOrDefault(c => c.Id == course.Id);
            courseToUpdate.CourseName = course.CourseName;
            courseToUpdate.CourseDescription = course.CourseDescription;
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.InstructorId = course.InstructorId;
        }
    }
}
