using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{
    /*
     * 
     * Создайте программу, при выполнении которой:
    •	во одном потоке будет выводиться мелодия;
    •	в другом потоке будет бесконечно выводиться строка «Поток номер 3» без отступов белым цветом букв на красном фоне;
    •	в следующем потоке будет бесконечно выводиться строка «Поток номер 4» с отступом в 10 пробелов красным цветом букв на белом фоне.
    */

    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart writeSecondThread = new ThreadStart(WriteSecondThread);
            Thread myThread = new Thread(writeSecondThread);
            myThread.Start();


            ThreadStart writeThread4 = new ThreadStart(WriteThread4);
            Thread myThread2 = new Thread(writeThread4);
            myThread2.Start();

            ThreadStart writeMelodyOutput = new ThreadStart(WriteMelodyOutput);
            Thread myThread3 = new Thread(writeMelodyOutput);
            myThread3.Start();

            Console.ReadLine();
        }

        static void WriteSecondThread()
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(new string('-', 10 + 19 + 3));
                Console.WriteLine("Поток номер 3");
            }
        }

        static void WriteThread4()
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new string(' ', 10) + "Поток номер 4");
            }
        }

        static void WriteMelodyOutput()
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Во одном потоке будет выводиться мелодия");
            }
        }

    }
}
