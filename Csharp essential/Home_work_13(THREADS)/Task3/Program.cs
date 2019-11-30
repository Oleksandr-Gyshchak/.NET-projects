using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Создайте метод, принимающий object и выводящий на экран некую строку.
    Саму строку и количество раз, которое она должна быть выведена на экран предполагается получить в качестве полей экземпляра класса,
    передаваемого как object. В числе тех же полей должен передаваться цвет строки и фона консоли.
    Создайте поток, в контексте которого выполните указанный метод.
    */

    class ThreadConfig
    {
        public string msg = "TestMsg";
        public int count = 4;
        public ConsoleColor ConsoleBackgroundColor = ConsoleColor.White;
        public ConsoleColor ConsoleForegroundColor = ConsoleColor.Red;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(WriteSecond);
            Thread myThread = new Thread(parameterizedThreadStart);

            ThreadConfig threadConfig = new ThreadConfig();
            myThread.Start(threadConfig);

            Console.ReadLine();
        }

        static void WriteSecond(object argument)
        {
            ThreadConfig config = (ThreadConfig)argument;

            for (int i = 0; i < config.count; i++)
            {
                Console.BackgroundColor = config.ConsoleBackgroundColor;
                Console.ForegroundColor = config.ConsoleForegroundColor;

                Console.WriteLine(config.msg);
            }
        }
    }
}
