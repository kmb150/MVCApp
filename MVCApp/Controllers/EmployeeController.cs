using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        // Object reference to Staff class
        private static Employee employee = new Employee();

        // GET: Employee
        public ActionResult Index()
        {
            // Get employee list from Model and send to View
            return View(employee.employeeList);
        }


        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                EmployeeProperties employeeProperties = new EmployeeProperties();

                employeeProperties.FirstName = collection["FirstName"];
                employeeProperties.LastName = collection["LastName"];
                employeeProperties.Address = collection["Address"];
                employeeProperties.Email = collection["Email"];
                employeeProperties.Salary = decimal.Parse(collection["Salary"]);

                employee.addNewEmployee(employeeProperties);

                return RedirectToAction("Index");
            }

            catch
            {
                return View();
            }
        }



        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
