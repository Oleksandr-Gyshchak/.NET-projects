using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


/*  
Пользователь вводит строку. 
Выполните проверку, используя регулярные выражения:
 Что строка введена латиницей и не содержит отдельных букв кириллицы или цифр;
 Строка введена латиницей и содержит отдельные буквы кириллицы, не содержит цифры;
 Строка введена латиницей и содержит цифры, не содержит кириллицу.
*/
namespace Home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            var onlyLatinLetters = new Regex(@"^[a-zA-Z]+$");
            var regexHasLatinLetters = new Regex(@"[a-zA-Z]+");
            var regexHasNumber = new Regex(@"[0-9]+");
            var regexHasCyrillic = new Regex(@"[а-яА-ЯёЁ]+");


            Console.WriteLine("Введите строку");
            string inputString = Console.ReadLine();

            bool isOnlyLatinLetters = onlyLatinLetters.IsMatch(inputString);
            bool hasLatinLetters = regexHasLatinLetters.IsMatch(inputString);
            bool hasNumber = regexHasNumber.IsMatch(inputString);
            bool hasCyrillic = regexHasCyrillic.IsMatch(inputString);


            if (isOnlyLatinLetters)
            {
                Console.WriteLine("Строка введена латиницей и не содержит отдельных букв кириллицы или цифр");
            }
            else if (
              hasLatinLetters == true &&
              hasCyrillic == true &&
              hasNumber == false
              )
            {
                Console.WriteLine("Строка введена латиницей и содержит отдельные буквы кириллицы, не содержит цифры");
            }
            else if (
              hasLatinLetters == true &&
              hasCyrillic == false &&
              hasNumber == true
              )
            {
                Console.WriteLine("Строка введена латиницей и содержит цифры, не содержит кириллицу");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.ReadKey();
        }
    }
}
