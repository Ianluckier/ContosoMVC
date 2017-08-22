using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Model;
using Contoso.Service;
using ContosoMVC.ViewModels;
using ContosoMVC.Filters;
//
namespace ContosoMVC.Controllers
{
    [HandleError]
    //[LogActionFilter]
    public class DepartmentController : Controller
    {
        DepartmentService departmentService;
 
        public DepartmentController()   
        {
            departmentService = new DepartmentService();
        }
        // Get All Departments
        public ActionResult Index()
        {
            //int i = 0;
            //int x = 1;
            //int z = x / i;
            List<Department> departments = departmentService.GetAllDepartments();
            return View(departments);
        }

        //Add New Department(Input Value)
        public ActionResult Create()
        {
            return View();
        }
        //Add Into DB
        [HttpPost]
        public ActionResult Create(Department department)
        {
            if(ModelState.IsValid)
            {
                departmentService.AddDepartment(department);
                return RedirectToAction("Index");
            } else
            {
                return View(department);
            }
        }

        // Get One Department Detail Information
        public ActionResult Details(int id)
        {
            Department department = departmentService.GetDepartmentById(id);
            return View(department);
        }

        //Update Department Information
        public ActionResult Edit(int id)
        {
            Department department = departmentService.GetDepartmentById(id);
            return View(department);
        }
        //Update Into DB
        [HttpPost]
        public ActionResult Edit(Department department)
        {
            departmentService.UpdateDepartment(department);
            return RedirectToAction("Index");
        }

        //Delete Department Information
        public ActionResult Delete(int id)
        {
            Department department = departmentService.GetDepartmentById(id);
            return View(department);
        }
        //Delete Into Database
        [HttpPost]
        public ActionResult Delete(Department department)
        {
            departmentService.DeleteDepartment(department);
            return RedirectToAction("Index");
        }

        public ActionResult CreateDepartmentCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDepartmentCourse(DepartmentCourseViewModel model)
        {
            Department dept = new Department();
            dept.Name = model.DepartmentName;
            dept.Budget = model.DepartmentBudget;
            departmentService.AddDepartment(dept);

            CourseService courseService = new CourseService();
            Course course = new Course();
            course.Title = model.CourseName;
            courseService.AddCourse(course);
            return View();
        }
    }
}