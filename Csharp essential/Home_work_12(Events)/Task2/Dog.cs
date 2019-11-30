using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Dog
    {
        public string Order { get; set; }

        public void OrderHandler(object sender, OrderEventArgs e)
        {
            if (sender is Owner)
            {
                Console.WriteLine($"Я выполняю команду {e.Order}");
                Order = e.Order;
            }
            else
            {
                Console.WriteLine("«Подозрительно смотрю на постороннего».");
            }


        }
    }
}
