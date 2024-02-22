using Entities.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudMethods.Abstracts
{
     public interface ICategory_Crud_Methods 
    {
        List<Category> GetAll();
        void Add(Category category);
        void Remove(Category category);
        void Update(Category category);
    }
}
