using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public CategoryDal()
        {
            
            _categories = new List<Category>();

        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.First(c=>c.Id==id);
        }

        public void Update(Category entity)
        {
            var updatedCategory = _categories.First(c => c.Id == entity.Id);
            updatedCategory.Name = entity.Name;
            updatedCategory.Courses = entity.Courses;
          
            
        }
    }
}
