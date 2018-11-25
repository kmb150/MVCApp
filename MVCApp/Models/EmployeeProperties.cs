using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeProperties
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
    }
    public class Employee
    {
        // Declare generic List data structure to hold staff details

        public List<EmployeeProperties> employeeList = new List<EmployeeProperties>();

        // Class constructor

        public Employee()
        {
            employeeList.Add(new EmployeeProperties
            {
                FirstName = "Iliyan",
                LastName = "Babulev",
                Address = "Blagoevgrad",
                Email = "liolio@abv.bg",
                Salary = 20000

            });
            employeeList.Add(new EmployeeProperties
            {
                FirstName = "Hristina",
                LastName = "Babuleva",
                Address = "Blagoevgrad",
                Email = "babuleva@abv.bg",
                Salary = 135000

            });
            employeeList.Add(new EmployeeProperties
            {
                FirstName = "Mladen",
                LastName = "Babulev",
                Address = "Blagoevgrad",
                Email = "babulev72@abv.bg",
                Salary = 50000

            });
        }

        // Method to add a new member of staff
        public void addNewEmployee(EmployeeProperties newEmployee)
        {
            employeeList.Add(newEmployee);
        }
    }

}