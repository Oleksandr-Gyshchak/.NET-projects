using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputYearMsg = "Введите год";
            string inputMonthMsg = "Введите месяц";
            string inputDateMsg = "Введите дату";
            string msgInvalidFullDate = "Invalid full date";
            string msgLeapYear = "Високосный год ";

            int inputYear = checkIsInteger(inputYearMsg);
            int inputMonth = checkIsInteger(inputMonthMsg);
            int inputDate = checkIsInteger(inputDateMsg);

            bool isValidInputFullDate = IsValidFullDate(inputYear, inputMonth, inputDate);

            if (!isValidInputFullDate)
            {
                Console.WriteLine(msgInvalidFullDate);
            }

            bool isInputLeapYear = IsLeapYear(inputYear);
            string fullDate = inputYear + "." + inputMonth + "." + inputDate;

            if (isInputLeapYear)
            {
                string resultLeapYear = msgLeapYear + fullDate;
                Console.WriteLine(resultLeapYear);
            }
            else
            {
                Console.WriteLine(fullDate);
            }


            Console.ReadKey();
        }

        static int checkIsInteger(string msg)
        {
            string msgNotInt = "Вы ввели не целое число !!";

            int result = 0;

            while (result == 0)
            {
                try
                {
                    Console.WriteLine(msg);

                    result = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(msgNotInt);
                }
            }
            return result;
        }

        static bool IsValidFullDate(int year, int month, int date)
        {
            bool isValidYear = ( year > 0 && year <= 2019 );
            bool isValidMonth = ( month > 0 && month <= 12 );
            bool isValidDate = ( date > 0 && date <= 31 );

            return isValidYear && isValidMonth && isValidDate;
        }

        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
