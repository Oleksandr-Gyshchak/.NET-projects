using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_17_task1
{
    enum PositionsList
    {
        Продавец,
        Менеджер,
        Директор
    }

    enum CityList
    {
        Киев,
        Лондон,
        Париж
    }

    class Employee
    {
        private readonly Random getrandom = new Random();


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string WorkCity { get; set; }

        public List<Employee> GenerateMockData(int count)
        {

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < count; i++)
            {

                Employee newEmployee = new Employee
                {
                    FirstName = "FirstName" + i,
                    LastName = "LastName" + i,
                    DateOfBirth = GenerateRandowDateTime(1970, 1999),
                    Position = GetRandomEnumValue<PositionsList>(),
                    Salary = getrandom.Next(5_000, 20_000),
                    WorkCity = GetRandomEnumValue<CityList>()
                };

                employees.Add(newEmployee);
            };

            return employees;
        }


        private DateTime GenerateRandowDateTime(int min, int max)
        {
            int randomYear = getrandom.Next(min, max);
            int randomMonthNr = getrandom.Next(1, 13);
            int maxDayNr = DateTime.DaysInMonth(randomYear, randomMonthNr);
            int randomDayNr = getrandom.Next(1, (maxDayNr + 1));

            return new DateTime(randomYear, randomMonthNr, randomDayNr);
        }

        private string GetRandomEnumValue<T>()
        {
            T[] values = (T[])Enum.GetValues(typeof(T));
            return (values[getrandom.Next(0, values.Length)]).ToString();
        }

    }
}
