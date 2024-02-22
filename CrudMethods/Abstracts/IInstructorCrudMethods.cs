using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudMethods.Abstracts
{
     public interface IInstructorCrudMethods
    {
        List<Instructor> GetAll();
        void Add(Instructor instructor);
        void Remove(Instructor instructor);
        void Update(Instructor instructor);
    }
}
