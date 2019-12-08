using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


/*
 Напишите консольное приложение, 
 позволяющие пользователю зарегистрироваться под
 «Логином», состоящем 
 только из символов латинского алфавита,
 и пароля, 
 состоящего из цифр и символов.
*/


namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternLogin = @"^[a-zA-Z]+$";

            var hasNumber = new Regex(@"[0-9]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            Regex regex;

            Console.WriteLine("Введите Login");
            string inputLogin = Console.ReadLine();


            Console.WriteLine("Введите Password");
            string inputPassword = Console.ReadLine();

            regex = new Regex(patternLogin);
            bool isMatchPatternLogin = regex.IsMatch(inputLogin);

            bool isMatchPatternPassword = hasNumber.IsMatch(inputPassword) && hasSymbols.IsMatch(inputPassword);


            if (isMatchPatternLogin == false && isMatchPatternPassword == false)
            {
                Console.WriteLine("Invalid Login and Password");
            }
            else if (isMatchPatternLogin == false)
            {
                Console.WriteLine("Invalid Login");
            }
            else if (isMatchPatternPassword == false)
            {
                Console.WriteLine("Invalid Password");
            }
            else
            {
                Console.WriteLine("Valid");
            }

            Console.ReadKey();
        }
    }
}
