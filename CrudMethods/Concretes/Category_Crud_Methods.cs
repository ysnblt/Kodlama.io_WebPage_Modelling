using CrudMethods.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudMethods.Concretes
{
    public class Category_Crud_Methods : ICategory_Crud_Methods
    {
        List<Category> _categories;
        public Category_Crud_Methods()
        {
            Category category1 = new Category();
            category1.Id = 1;
            category1.CategoryName = "C#";

            Category category2 = new Category();
            category2.Id = 2;
            category2.CategoryName = "Java";

            Category category3 = new Category();
            category3.Id = 3;
            category3.CategoryName = "Phyton";

            _categories = new List<Category>();
            _categories.Add(category1);
            _categories.Add(category2);
            _categories.Add(category3);

        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categories.ToList();
        }

        public void Remove(Category category)
        {
            _categories.Remove(category);
        }

        public void Update(Category category)
        {
            Category upDatedCategory = _categories.Where(c => c.Id == category.Id).FirstOrDefault();
            upDatedCategory.CategoryName = category.CategoryName;

        }
    }
}
