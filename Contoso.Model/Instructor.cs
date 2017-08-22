using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model
{
    public class Instructor
    {   
        [Key]
        [ForeignKey("Person")]
        public int Id { get; set; }
        public DateTime HireDate { get; set; }
        public Person Person { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
