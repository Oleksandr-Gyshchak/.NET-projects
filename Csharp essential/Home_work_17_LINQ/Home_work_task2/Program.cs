using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intList = new[]
            {
                2,4,6,8,
                5,10,15,20,
                9,7
            };


            var powerOfTwo = from number in intList
                             where number % 2 == 0
                             select number;

            foreach (int number in powerOfTwo)
            {
                Console.WriteLine($"{number}");
            }


            Console.WriteLine("-------");

            var query = intList
            .Where(number => number % 5 == 0);
            //.Select(number => number);

            foreach (int number in query)
            {
                Console.WriteLine($"{number}");
            }


            Console.ReadKey();

        }
    }
}
