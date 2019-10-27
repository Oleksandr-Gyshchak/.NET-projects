using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone(10, "Bionic", "2 GB");
            smartphone.ShowInfo();
            smartphone.CanDo();

            Console.ReadKey();
        }
    }
}
