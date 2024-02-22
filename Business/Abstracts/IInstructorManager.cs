using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
     interface IInstructorManager
    {
        List<Instructor> GetCategories();
        void Add(Instructor ınstructor);
        void Remove(Instructor ınstructor);
        void Update(Instructor ınstructor);
    }
}
