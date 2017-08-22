using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class DepartmentRepository : IRepository<Department>
    {
        public void Add(Department entity)
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                contosoDbContent.Departments.Add(entity);
                contosoDbContent.SaveChanges();
            }
        }

        public void Delete(Department entity)
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                Department department = contosoDbContent.Departments.Where(d => d.Id == entity.Id).FirstOrDefault();
                if (department != null)
                {
                    contosoDbContent.Departments.Remove(department);
                    contosoDbContent.SaveChanges();
                }
            }
        }

        public List<Department> GetAll()
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                return contosoDbContent.Departments.ToList();
            }
        }

        public Department GetById(int id)
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                Department department = contosoDbContent.Departments.Where(d => d.Id == id).FirstOrDefault();
                return department;
            }
        }

        public void Update(Department entity)
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                contosoDbContent.Departments.Attach(entity);
                contosoDbContent.Entry(entity).State = EntityState.Modified;
                contosoDbContent.SaveChanges();
            }
        }
    }
}
