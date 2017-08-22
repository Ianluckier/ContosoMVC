using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class CourseRepository : IRepository<Course>
    {
        public void Add(Course entity)
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                contosoDbContent.Courses.Add(entity);
                contosoDbContent.SaveChanges();
            }
        }

        public void Delete(Course entity)
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                Course course = contosoDbContent.Courses.Where(c => c.Id == entity.Id).FirstOrDefault();
                if (course != null)
                {
                    contosoDbContent.Courses.Remove(course);
                    contosoDbContent.SaveChanges();
                }
            }
        }

        public List<Course> GetAll()
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                return contosoDbContent.Courses.ToList();
            }
        }

        public Course GetById(int id)
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                Course course = contosoDbContent.Courses.Where(c => c.Id == id).FirstOrDefault();
                return course;
            }
        }

        public void Update(Course entity)
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                contosoDbContent.Courses.Attach(entity);
                contosoDbContent.Entry(entity).State = EntityState.Modified;
                contosoDbContent.SaveChanges();
            }
        }
    }
}
