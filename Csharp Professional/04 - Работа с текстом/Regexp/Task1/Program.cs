using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
Пользователь вводит строку в консоль.Создайте приложение, которое определяет:
•	В строке есть цифры;
•	В строке есть не цифровые элементы.
*/

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();

            Console.ReadKey();
        }

        private static void Task1()
        {
            // определяет символы цифр.
            string pattern = @"\d";

            var regex = new Regex(pattern);

            while (true)
            {
                Console.WriteLine("Введите строку");
                string inputString = Console.ReadLine();

                if (inputString == "exit")
                    break;

                if (String.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine("Пустая строка");
                    continue;
                }

                bool success = regex.IsMatch(inputString);

                Console.WriteLine(success ? " Есть цифры" : " Нету цифр");
            }
        }

        private static void Task2()
        {
            // Определяет любой символ, который не является цифрой. 
            string pattern = @"\D";

            var regex = new Regex(pattern);

            while (true)
            {
                Console.WriteLine("Введите строку (Task2)");
                string inputString = Console.ReadLine();

                if (inputString == "exit")
                    break;

                if (String.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine("Пустая строка");
                    continue;
                }

                bool success = regex.IsMatch(inputString);

                Console.WriteLine(success ? "Есть символ который не является цифрой" : "все цифры");
            }
        }

    }
}
