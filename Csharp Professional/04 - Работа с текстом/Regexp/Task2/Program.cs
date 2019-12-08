using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


/*
 Пользователь вводит строку в консоль. Выполните замену:
Всех цифр на пробелы:
•	так, что каждый символ числа заменяется на пробел;
•	так, что каждая группа символов чисел заменяется на пробел; 
•	так, что каждая группа нечисловых символов заменяется на пробел.
 */
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            InitTask2();
        }

        static private void InitTask2()
        {
            string pattern1 = @"\d";
            string pattern2 = @"\d+";
            string pattern3 = @"\D+";

            string spaceSymbol = " ";

            Console.WriteLine("Введите строку");
            string inputText = Console.ReadLine();

            //каждый символ числа заменяется на пробел;
            Console.WriteLine(Regex.Replace(inputText, pattern1, spaceSymbol));

            // каждая группа символов чисел заменяется на пробел
            Console.WriteLine(Regex.Replace(inputText, pattern2, spaceSymbol));

            // каждая группа нечисловых символов заменяется на пробел.
            Console.WriteLine(Regex.Replace(inputText, pattern3, spaceSymbol));

            Console.ReadKey();
        }
    }
}
