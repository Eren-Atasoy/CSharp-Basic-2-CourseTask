using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public Category()
        {
            
        }
        public Category(int id,string name,List<Course> courses)
        {
            Id = id; Name = name; Courses = courses;
        }

       

        public  int? Id { get; set; }
        public  string? Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
