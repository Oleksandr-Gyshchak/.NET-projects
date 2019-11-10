using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_11
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary2<string, string, string> dictionary = new Dictionary2<string, string, string>();

            for (int i = 0; i < 10; i++)
            {
                dictionary.Add("key" + i, "value1_" + i, "value2_" + i);
            }

            Console.WriteLine(dictionary.Lenght);

            string keyQuery = "key" + 2;

            Console.WriteLine(dictionary.GetTranslation(keyQuery, 1));

            dictionary.RemoveTranslation(keyQuery);
            Console.WriteLine(dictionary.GetTranslation(keyQuery, 2));

            Console.WriteLine(dictionary.Lenght);

            dictionary.Clear();
            Console.WriteLine(dictionary.Lenght);

            Console.ReadKey();
        }
    }
}
