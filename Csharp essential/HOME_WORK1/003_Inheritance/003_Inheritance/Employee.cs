using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Inheritance
{
    class Employee
    {
        protected int age { set; get; }
        protected string name { set; get; }
        protected int workExperience { set; get; }
        protected double salary { set; get; }

        public Employee(int age, string name, int workExperience, double salary)
        {
            this.age = age;
            this.name = name;
            this.workExperience = workExperience;
            this.salary = salary;
        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"Name {name}, age {age}, workExperience {workExperience}, salary {salary}");
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

    }
}
