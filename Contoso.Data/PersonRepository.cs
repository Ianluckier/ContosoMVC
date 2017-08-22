using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using System.Data.Entity;

namespace Contoso.Data
{
    public class PersonRepository : IRepository<Person>
    {
        public void Add(Person entity)
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                contosoDbContent.Persons.Add(entity);
                contosoDbContent.SaveChanges();
            }
        }

        public void Delete(Person entity)
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                Person person = contosoDbContent.Persons.Where(p => p.Id == entity.Id).FirstOrDefault();
                if (person != null)
                {
                    contosoDbContent.Persons.Remove(person);
                    contosoDbContent.SaveChanges();
                }
            }
        }

        public List<Person> GetAll()
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                return contosoDbContent.Persons.ToList();
            }
        }

        public Person GetById(int id)
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                Person person = contosoDbContent.Persons.Where(p => p.Id == id).FirstOrDefault();
                return person;
            }
        }

        public void Update(Person entity)
        {
            using (var contosoDbContent = new ContosoDbContext())
            {
                contosoDbContent.Persons.Attach(entity);
                contosoDbContent.Entry(entity).State = EntityState.Modified;
                contosoDbContent.SaveChanges();
            }
        }
    }
}
