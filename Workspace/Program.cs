using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Workspace
{

    public class Program
    {
        static void Main()
        {
            List<Course> enginCourses = new List<Course>(); 
            List<Course> erenCourses = new List<Course>();

            List<Course> ProgramlamaCategoryCourses = new List<Course>();

            Category category = new Category(1, "Programlama",  ProgramlamaCategoryCourses);

            Instructor instructor = new Instructor(1, "Engin", "Demiroğ", "Deneyimli bir hoca", "deneme/url", enginCourses);
            Instructor instructor1 = new Instructor(2, "Eren", "Atasoy", "Orta seviye deneyimli bir hoca", "deneme2/url", erenCourses);

            Course course = new Course(1, 0, "Senior c#", "zor kurs", instructor, category);
            Course course1 = new Course(2, 20, "Junior c++ ", "kolay kurs", instructor1, category);
            CourseManager courseManager = new CourseManager(new CourseDal());
            var a = courseManager.GetAll();

            
          
            courseManager.Add(course);
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i].Name + "-----------" + a[i].Id + "-----------" + a[i].Category.Name + "\n");
            }
            courseManager.Add(course1);
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i].Name + "-----------" + a[i].Id + "-----------" + a[i].Category.Name + "\n");
            }
            var b = courseManager.GetById(2);
            Console.WriteLine(b.Name);
          
        }


    }
}