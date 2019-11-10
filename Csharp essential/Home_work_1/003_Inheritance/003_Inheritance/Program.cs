using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director(20, "Ivan", 10, 10.4);

            Salesman salesman1 = new Salesman(21, "Sasha", 100, 10.41, director);
            Salesman salesman2 = new Salesman(22, "Ivan", 200, 20.41, director);
            Salesman salesman3 = new Salesman(23, "Sasha2", 300, 30.41, director);


            director.AddSubordinate(salesman1);
            director.AddSubordinate(salesman2);
            director.AddSubordinate(salesman3);

            director.ShowAllSubordinateInfo();

            director.SetSalary(65);
            salesman1.SetSalary(22);
            salesman2.SetSalary(23);
            salesman3.SetSalary(24);

            Console.WriteLine("\n new ------------");
            director.ShowEmployeeInfo();
            director.ShowAllSubordinateInfo();

            Console.ReadKey();

        }
    }
}
