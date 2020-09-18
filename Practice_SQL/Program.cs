using Practice_SQL.Controllers;
using Practice_SQL.Models;
using System;
using System.Linq;

namespace Practice_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Location
                    -Name
                    -Address
                    -PostalCode
                    -City
                Employee
                    -FirstName
                    -LastName
                    -BirthDate
                    -HireDate
                    -EndDate
            */

            // In class practice: Add a method to the EmployeeController that will get an employee by their ID.

            string name;
          

            Console.Write("Please enter a Full Name: ");
            name = Console.ReadLine().Trim().ToUpper();

            EmployeeController employeeController = new EmployeeController();
            Employee target = employeeController.GetEmployeeByName(name.Split(' ')[0], name.Split(' ')[1]);

            LocationController locationController = new LocationController();
            Location work = locationController.GetLocationFromEmployee(target.ID);

            Console.WriteLine($"{target.FirstName} {target.LastName} works at {work.Name} - {work.Address} {work.PostalCode}, {work.City}.");



        }

    }
}
