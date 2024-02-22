using Business.Abstracts;
using CrudMethods.Abstracts;
using CrudMethods.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategory_Crud_Methods _category_Crud_Methods;
        public CategoryManager(Category_Crud_Methods category_Crud_Methods)
        {
                _category_Crud_Methods = category_Crud_Methods;
        }
        public void Add(Category category)
        {
            _category_Crud_Methods.Add(category);
        }

        public List<Category> GetCategories()
        {
            return _category_Crud_Methods.GetAll();
        }

        public void Remove(Category category)
        {
            _category_Crud_Methods.Remove(category);
        }

        public void Update(Category category)
        {
            _category_Crud_Methods.Update(category);
        }
    }
}
