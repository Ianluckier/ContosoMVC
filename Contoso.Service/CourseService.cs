using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using Contoso.Data;

namespace Contoso.Service
{
    public class CourseService
    {
        CourseRepository courseRepository;
        public CourseService()
        {
            courseRepository = new CourseRepository();
        }

        public List<Course> GetAllCourses()
        {
            return courseRepository.GetAll();
        }

        public void AddCourse(Course course)
        {
            courseRepository.Add(course);
        }

        public Course GetCourseById(int id)
        {

            return courseRepository.GetById(id);
        }

        public void UpdateCourse(Course course)
        {
            courseRepository.Update(course);
        }

        public void DeleteCourse(Course course)
        {
            courseRepository.Delete(course);
        }
    }
}
