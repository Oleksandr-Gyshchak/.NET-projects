using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            string msgEmployeeCount = "Введите количество сотрудников предприятия ";

            int employeeCount = 0;
            double[,] databaseArr;

            Console.WriteLine(msgEmployeeCount);

            employeeCount = int.Parse(Console.ReadLine());

            // 1-я строка отвечает за стоимость трудового часа сотрудника
            // 2-я за количество отработанных сотрудником часов в отчетном периоде
            databaseArr = new double[2, employeeCount];

            for (int i = 0; i < employeeCount; i++)
            {
                AddEmployee(i, ref databaseArr);
            }


            DisplayEmployeeSalaryByIndex(databaseArr, employeeCount);

            DisplayAllEmployeeSalary(databaseArr, employeeCount);

            Console.ReadKey();
        }

        static void AddEmployee(int employeeIndex, ref double[,] databaseArr)
        {
            string msgHourlyRate = "Введите стоимость 1 трудового часа сотрудника  №";
            string msgAmountOfHoursWorked = "Введите количество отработанных часов для сотрудника №";

            int employeeNumber = employeeIndex + 1;
            double hourlyRate = 0;
            int amountHoursWorked = 0;


            Console.WriteLine(msgHourlyRate + employeeNumber);
            hourlyRate = double.Parse(Console.ReadLine());

            Console.WriteLine(msgAmountOfHoursWorked + employeeNumber);
            amountHoursWorked = int.Parse(Console.ReadLine());


            databaseArr[0, employeeIndex] = hourlyRate;
            databaseArr[1, employeeIndex] = amountHoursWorked;
        }

        static void DisplayEmployeeSalaryByIndex(double[,] databaseArr, int employeeCount)
        {
            string msgInputEmployeeId = "Введите № сотрудника от 0 ";
            string msgSalary = "Объем заработной платы сотрудника № ";
            string invalidEmployeeId = "Вы ввели ID несуществующего сотрудника";
            int employeeIndex = 0;

            Console.WriteLine($"{msgInputEmployeeId} до {employeeCount - 1}");

            try
            {
                employeeIndex = int.Parse(Console.ReadLine());
                double total = total = databaseArr[0, employeeIndex] * databaseArr[1, employeeIndex];
                Console.WriteLine($"{msgSalary}{employeeIndex} : {total}");
            }
            catch (Exception exc)
            {
                Console.WriteLine($"{invalidEmployeeId} : {employeeIndex}");
            }

        }

        static void DisplayAllEmployeeSalary(double[,] databaseArr, int employeeCount)
        {
            string msgTotal = "Общий объем бюджета заработной платы за отчетный период ";

            double total = 0;

            for (int i = 0; i < employeeCount; i++)
            {
                total += databaseArr[0, i] * databaseArr[1, i];
            }

            Console.WriteLine($"{msgTotal} : {total}");
        }
    }
}
