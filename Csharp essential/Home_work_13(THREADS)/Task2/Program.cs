using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Создайте метод, получающий хэшкод своего потока, и выводящий его на экран с задержкой в 1 секунду.
    Создайте три вторичных потока в которых запустите выполнение этого метода.
    */

    class Program
    {
        static void Main(string[] args)
        {

            Thread thread1 = new Thread(GetThreadHashCode);
            thread1.Start();

            Thread thread2 = new Thread(GetThreadHashCode);
            thread2.Start();

            Thread thread3 = new Thread(GetThreadHashCode);
            thread3.Start();

            Console.ReadKey();
        }

        static void GetThreadHashCode()
        {
            while (true)
            {
                int threadHashCode = Thread.CurrentThread.GetHashCode();
                Console.WriteLine(threadHashCode);
                Thread.Sleep(1000);
            }
        }
    }
}
