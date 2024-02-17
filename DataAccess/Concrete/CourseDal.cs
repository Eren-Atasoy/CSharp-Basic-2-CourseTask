using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;

       

        public CourseDal()
        {
           

            _courses = new List<Course>() ;
        }
        public void Add(Course entity)
        {
            _courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            _courses.Remove(entity);
        }

        public List<Course> GetAll()
        {
           return _courses;
        }

        public Course GetById(int id)
        {
           return _courses.FirstOrDefault(c => c.Id == id);
          
        }

        

        public void Update(Course entity)
        {
            try
            {
                var updatedCourse = _courses.First(c => c.Id == entity.Id);
                updatedCourse.Name = entity.Name;
                updatedCourse.Description = entity.Description;
                updatedCourse.Price = entity.Price;
                updatedCourse.Category = entity.Category;
                updatedCourse.Instructor = entity.Instructor;
            }
            catch (Exception)
            {
                Console.WriteLine("Yolladığınız Id ile eşleşen Id olmadığından güncelleme işlemi yapılamadı");
               
            }

           
            
        }
    }
}
