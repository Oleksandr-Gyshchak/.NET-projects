using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Создайте класс Dictionary с функциональностью словаря без определенной длинны. 
    Используйте 2 массива в теле Dictionary. 
    Реализуйте обращение к словарю по индексу в методе Main. 
    Реализуйте возможность заполнения словаря используя индексаторы.
*/

namespace Home_work_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary rusEngDictionary = new Dictionary();

            Console.WriteLine(rusEngDictionary["1"]);
            Console.WriteLine(rusEngDictionary["привет"]);
            Console.WriteLine(rusEngDictionary["Досведание"]);


            Console.WriteLine("----------");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(rusEngDictionary[i]);
            }
            Console.WriteLine("----------");

            rusEngDictionary[0] = "Весна";
            Console.WriteLine(rusEngDictionary[0]);

            rusEngDictionary[15] = "Тест, Test";
            Console.WriteLine(rusEngDictionary[15]);

            rusEngDictionary[16] = "Тест2";
            Console.WriteLine(rusEngDictionary[16]);


            Console.ReadKey();
        }
    }
}
