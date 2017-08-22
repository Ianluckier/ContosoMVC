using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class InstructorRepository : IRepository<Instructor>
    {
        public void Add(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                return contosoDbContent.Instructors.ToList();
            }
        }

        public Instructor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor entity)
        {
            throw new NotImplementedException();
        }
    }
}
