using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Model;
using Contoso.Service;

namespace ContosoMVC.Controllers
{
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
            departmentService.AddDepartment(department);
            return RedirectToAction("Index");
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
    }
}