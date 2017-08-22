using Contoso.Data;
using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class PersonService
    {
        PersonRepository personRepository;
        public PersonService()
        {
            personRepository = new PersonRepository();
        }

        public List<Person> GetAllPersons()
        {
            return personRepository.GetAll();
        }

        public void AddPerson(Person person)
        {
            personRepository.Add(person);
        }

        public Person GetPersonById(int id)
        {

            return personRepository.GetById(id);
        }

        public void UpdatePerson(Person person)
        {
            personRepository.Update(person);
        }

        public void DeletePerson(Person person)
        {
            personRepository.Delete(person);
        }
    }
}
