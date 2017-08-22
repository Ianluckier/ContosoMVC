using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int InstructorId { get; set; }
        public string RowVersion { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instructor Instructor { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
