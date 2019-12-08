using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* 
Пользователь вводит строку. 
Выполните проверку, что данная строка содержит только цифры, буквы или нижнее подчеркивание. 
Если строка содержит цифры, выполните проверку не содержит ли строка два нуля подряд
Выведите результат на экран.
*/

namespace Task3
{
    public class InitTask3
    {
        //только цифры, буквы или нижнее подчеркивание. 
        string pattern1 = @"^\w+$";
        string msg = "содержит только цифры, буквы или нижнее подчеркивание";
        string msgTwoZero = "содержит строка два нуля подряд";

        Regex regex;

        public void Init()
        {
            Console.WriteLine("Введите строку");

            string inputText = Console.ReadLine();
            regex = new Regex(pattern1);

            bool isMatchPattern1 = regex.IsMatch(inputText);

            Console.WriteLine(isMatchPattern1 ? $"данная строка {msg}" : $"не {msg}");

            if (isMatchPattern1 && IsContainsInt(inputText))
            {
                string pattern2 = "[0]{2}";

                regex = new Regex(pattern2);
                bool isMatchPattern2 = regex.IsMatch(inputText);

                Console.WriteLine(isMatchPattern2 ? msgTwoZero : $"не {msgTwoZero}");
            }


            Console.ReadKey();
        }

        private bool IsContainsInt(string inputText)
        {
            string pattern2 = @"\d";

            Regex regex = new Regex(pattern2);
            return regex.IsMatch(inputText);
        }

    }
}
