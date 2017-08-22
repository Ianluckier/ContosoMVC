using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Model;
using Contoso.Service;

namespace ContosoMVC.Controllers
{
    public class CourseController : Controller
    {
        CourseService courseService;
        
        public CourseController()
        {
            courseService = new CourseService();
        }
        // Get All Courses
        public ActionResult Index()
        {
            List<Course> courses = courseService.GetAllCourses();
            return View(courses);
        }

        //Add New Course(Input Value)
        public ActionResult Create()
        {
            return View();
        }
        //Add Into DB
        [HttpPost]
        public ActionResult Create(Course course)
        {
            courseService.AddCourse(course);
            return RedirectToAction("Index");
        }

        // Get One Course Detail Information
        public ActionResult Details(int id)
        {
            Course course = courseService.GetCourseById(id);
            return View(course);
        }

        //Update Course Information
        public ActionResult Edit(int id)
        {
            Course course = courseService.GetCourseById(id);
            return View(course);
        }
        //Update Into DB
        [HttpPost]
        public ActionResult Edit(Course course)
        {
            courseService.UpdateCourse(course);
            return RedirectToAction("Index");
        }

        //Delete Course Information
        public ActionResult Delete(int id)
        {
            Course course = courseService.GetCourseById(id);
            return View(course);
        }
        //Delete Into Database
        [HttpPost]
        public ActionResult Delete(Course course)
        {
            courseService.DeleteCourse(course);
            return RedirectToAction("Index");
        }
    }
}