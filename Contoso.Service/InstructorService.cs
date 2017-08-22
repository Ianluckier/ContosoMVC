using Contoso.Data;
using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class InstructorService
    {
        InstructorRepository instructorRepository;
        public InstructorService()
        {
            instructorRepository = new InstructorRepository();
        }

        public List<Instructor> GetAllInstructors()
        {
            return instructorRepository.GetAll();
        }
    }
}
