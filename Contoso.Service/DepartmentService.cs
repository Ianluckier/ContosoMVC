using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using Contoso.Data;

namespace Contoso.Service
{
    public class DepartmentService
    {
        DepartmentRepository departmentRepository;
        public DepartmentService()
        {
            departmentRepository = new DepartmentRepository();
        }

        public List<Department> GetAllDepartments()
        {
            return departmentRepository.GetAll();
        }

        public void AddDepartment(Department department)
        {
            departmentRepository.Add(department);
        }

        public Department GetDepartmentById(int id)
        {

            return departmentRepository.GetById(id);
        }

        public void UpdateDepartment(Department department)
        {
            departmentRepository.Update(department);
        }

        public void DeleteDepartment(Department department)
        {
            departmentRepository.Delete(department);
        }
    }
}
