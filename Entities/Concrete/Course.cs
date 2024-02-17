using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course : IEntity

    {
        public Course()
        {

        }
        public Course(int id, double price, string name, string description, Instructor instructor, Category category)
        {
            Id = id; Price = price; Name = name; Description = description; Category = category;
            Instructor = instructor;
        }
        public int? Id { get; set; }
        public double? Price { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Instructor? Instructor { get; set; }
        public Category? Category { get; set; }
    }
}
