using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
     interface ICategoryManager
    {
        List<Category> GetCategories();
        void Add(Category category);
        void Remove(Category category);
        void Update(Category category);
    }
}
