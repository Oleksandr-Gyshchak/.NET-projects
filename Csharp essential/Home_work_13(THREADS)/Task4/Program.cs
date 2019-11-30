using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    /*
    Создайте метод, выводящий бесконечное количество раз строку.
    В теле Main запустите созданный метод во вторичном потоке.
    Ниже в методе Main выполните вывод на экран другой строки - 20 раз с ожиданием в 2 секунды между выводами.
    Программа должна завершиться по выполнению кода из основного потока.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Thread newThread = new Thread(WriteLine);
            newThread.Start();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Primary Thread {i}");
                Thread.Sleep(2000);
            }

            newThread.IsBackground = true;
            //Console.ReadKey();
        }

        static void WriteLine()
        {
            while (true)
            {
                Console.WriteLine("Secondary");
                Thread.Sleep(1000);
            }
        }
    }
}
