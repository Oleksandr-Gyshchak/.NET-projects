using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work_1
{
    class Program
    {
        delegate void Del<T>(ref T x, ref T y);

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void Display<T>(ref T x, ref T y)
        {
            Console.WriteLine($"значение первого аргумента – {x}, значение второго аргумента – {y}");
        }


        static void Main(string[] args)
        {

            /*
             Создайте делегат Del, параметризированный местом заполнения типом T, и сообщаемый с методом,
             который ничего не возвращает и принимает два аргумента типа T – оба по ссылке.
            Создать методы, сообщаемые с Del:
            1.	Меняющий значения переменных местами.
            2.	Выводящий на экран строку: «значение первого аргумента – {0}, значение второго аргумента – {1}»;
            Сообщите методы с экземпляром делегата del1, закрытым интом, в таком порядке: 2, 1, 2.
            Создайте другой экземпляр делегата - del2, закрытый строкой, и сообщите с ним методы в таком же порядке.
            Проверьте работу делегата целочисленными значениями и со строковыми значениями.
            */

            int x = 10;
            int y = 20;

            Del<int> del1 = new Del<int>(Display);
            del1(ref x, ref y);

            del1 = new Del<int>(Swap);
            del1(ref x, ref y);

            del1 = new Del<int>(Display);
            del1(ref x, ref y);

            Console.WriteLine("------------");
            //2
            string x1 = "Привет";
            string y1 = "Пока";

            Del<string> del2 = new Del<string>(Display);
            del2(ref x1, ref y1);

            del2 = new Del<string>(Swap);
            del2(ref x1, ref y1);

            del2 = new Del<string>(Display);
            del2(ref x1, ref y1);


            Console.ReadKey();
        }
    }
}
