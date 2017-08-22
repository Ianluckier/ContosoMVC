using Contoso.Model;
using Contoso.Service;
using Contoso.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoMVC.Controllers
{
    public class PersonController : Controller
    {
        PersonService personService;

        public PersonController()
        {
            personService = new PersonService();
        }
        // Get All Persons
        public ActionResult Index()
        {
            List<Person> persons = personService.GetAllPersons();
            return View(persons);
        }

        //Add New Person(Input Value)
        public ActionResult Create()
        {
            return View();
        }
        //Add Into DB
        [HttpPost]
        public ActionResult Create(Person person)
        {
            personService.AddPerson(person);
            return RedirectToAction("Index");
        }

        // Get One Person Detail Information
        public ActionResult Details(int id)
        {
            Person person = personService.GetPersonById(id);
            return View(person);
        }

        //Update Person Information
        public ActionResult Edit(int id)
        {
            Person person = personService.GetPersonById(id);
            return View(person);
        }
        //Update Into DB
        [HttpPost]
        public ActionResult Edit(Person person)
        {
            personService.UpdatePerson(person);
            return RedirectToAction("Index");
        }

        //Delete Person Information
        public ActionResult Delete(int id)
        {
            Person person = personService.GetPersonById(id);
            return View(person);
        }
        //Delete Into Database
        [HttpPost]
        public ActionResult Delete(Person person)
        {
            personService.DeletePerson(person);
            return RedirectToAction("Index");
        }
    }
}