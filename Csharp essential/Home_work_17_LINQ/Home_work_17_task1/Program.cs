using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_17_task1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new Employee().GenerateMockData(1000);

            var query = employees
                        .Where(emp => (DateTime.Now.Year - emp.DateOfBirth.Year) > 25)
                        .Where(emp => emp.Salary > 10_000)
                        .Where(emp => emp.WorkCity == CityList.Киев.ToString())
                        .OrderBy(emp => emp.Salary)
                        .Select(emp => new
                        {
                            FirstName = emp.FirstName,
                            Salary = emp.Salary,
                            Age = DateTime.Now.Year - emp.DateOfBirth.Year
                        });

            foreach (var item in query)
            {
                Console.WriteLine($"{item.FirstName} {item.Age} {item.Salary}");
            }

            Console.ReadKey();

        }


    }

}


