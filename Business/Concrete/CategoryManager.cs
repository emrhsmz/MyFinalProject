using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager :ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //iş kodları
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public List<Category> GetById(int categoryId)
        {
            return _categoryDal.GetAll(c => c.CategoryID == categoryId);
        }

        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
