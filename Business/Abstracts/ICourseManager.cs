using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
     interface ICourseManager
    {
        List<Course> GetCourses();
        void Add(Course course);
        void Remove(Course course);
        void Update(Course course);
    }
}
