using Business.Abstracts;
using CrudMethods.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseManager
    {
        private readonly ICourseCrudMethods _courseCrudMethods;

        public CourseManager(ICourseCrudMethods courseCrudMethods)
        {
                _courseCrudMethods = courseCrudMethods;
        }
        public void Add(Course course)
        {
            _courseCrudMethods.Add(course);
        }

        public List<Course> GetCourses()
        {
           return _courseCrudMethods.GetAll();
        }

        public void Remove(Course course)
        {
            _courseCrudMethods.Delete(course);
        }

        public void Update(Course course)
        {
            _courseCrudMethods.Update(course);
        }
    }
}
