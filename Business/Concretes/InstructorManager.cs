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
    public class InstructorManager : IInstructorManager
    {
        private readonly IInstructorCrudMethods _ınstructorCrudMethods;
        public InstructorManager(IInstructorCrudMethods ınstructorCrudMethods)
        {
            _ınstructorCrudMethods = ınstructorCrudMethods;
        }
        public void Add(Instructor ınstructor)
        {
            _ınstructorCrudMethods.Add(ınstructor);
        }

        public List<Instructor> GetCategories()
        {
            return _ınstructorCrudMethods.GetAll();
        }

        public void Remove(Instructor ınstructor)
        {
            _ınstructorCrudMethods.Remove(ınstructor);
        }

        public void Update(Instructor ınstructor)
        {
            _ınstructorCrudMethods.Update(ınstructor);
        }
    }
}
