using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class ContosoDbContext : DbContext
    {
        public ContosoDbContext():base("name=ContosoMVC")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssginment> OfficeAssignments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
