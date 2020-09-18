using Practice_SQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice_SQL.Controllers
{
    public class LocationController
    {
        public Location GetLocationFromEmployee(int employeeID)
        {
            Location toReturn = null;

            try
            {
                using (EmployeeContext context = new EmployeeContext())
                {
                    // Single will throw an Exception if there is not only one item in a collection.
                    // SingleOrDefault will return null if there is not only one.
                    toReturn = context.Locations.Where(x => x.Employees.Where(y => y.ID == employeeID).SingleOrDefault() != null).SingleOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Employee Control Exception: " + e.Message);
            }

            return toReturn;
        }
    }
}