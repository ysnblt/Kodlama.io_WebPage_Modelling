using CrudMethods.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudMethods.Concretes
{
    public class InstructorCrudMethods : IInstructorCrudMethods
    {
        List<Instructor> _instructors;
        public InstructorCrudMethods()
        {
            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.FirstName = "Yasin";
            instructor1.LastName = "Bolat";

            Instructor instructor2 = new Instructor();
            instructor2.Id = 1;
            instructor2.FirstName = "Yasemin";
            instructor2.LastName = "Bolat";

            List<Instructor> _instructors = new List<Instructor>();
            _instructors.Add(instructor1);
            _instructors.Add(instructor2);
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Remove(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public void Update(Instructor instructor)
        {
            Instructor updatedInstructor = _instructors.Where(i=> i.Id == instructor.Id).FirstOrDefault();
            updatedInstructor.FirstName = instructor.FirstName;
            updatedInstructor.LastName = instructor.LastName;
        }
    }
}
