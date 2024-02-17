using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _Instructor;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _Instructor = instructorDal;
            
        }
        public void Add(Instructor entity)
        {
            _Instructor.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            _Instructor.Delete(entity);
        }

        public List<Instructor> GetAll()
        {
            return _Instructor.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _Instructor.GetById(id);
        }

        public void Update(Instructor entity)
        {
            _Instructor.Update(entity);
        }
    }
}
