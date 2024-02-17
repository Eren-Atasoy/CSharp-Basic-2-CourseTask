using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
       
        public InstructorDal()
        {
            
            
            
            _instructors =new List<Instructor>() ;

        }
        public void Add(Instructor entity)
        {
           _instructors.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            _instructors.Remove(entity);
        }

        public List<Instructor> GetAll()
        {
           return _instructors;
        }

        public Instructor GetById(int id)
        {

            return _instructors.First(c => c.Id == id);
        }
            public void Update(Instructor entity)
        {
            var updatedCategory = _instructors.First(c => c.Id == entity.Id);
            updatedCategory.Id = entity.Id;
            updatedCategory.FirstName = entity.FirstName;
            updatedCategory.LastName = entity.LastName;
            
        }
    }
}
