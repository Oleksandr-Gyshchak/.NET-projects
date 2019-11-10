using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Напишите обобщенный класс, который может хранить в массиве объекты любого одного типа.
             Кроме того, данный класс должен иметь механизмы для добавления данных в массив, удаления из массива,
             получения элемента из массива по индексу и метод, возвращающий длину массива.
             Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления             
            */

            ColectionList<int> colectionList = new ColectionList<int>();

            colectionList.Add(1);
            colectionList.Add(31);
            colectionList.Add(52);

            Console.WriteLine($"Length {colectionList.ListLength()}");

            try
            {
                Console.WriteLine(colectionList.GetItemByIndex(1));
            }
            catch
            {
                Console.WriteLine("INVAID INDEX");
            }


            colectionList.Remove(2);
            colectionList.Remove(31);

            Console.ReadKey();

        }
    }
}
