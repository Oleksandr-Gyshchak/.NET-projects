using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /*
        Создайте класс  Human. Создайте делегат, который может быть проассоциирован с методом, который ничего не возвращает и не принимает.
        В теле класса создайте событие JumpE, в соответствии с делегатом. 
        Создайте защищенный механизм доступа к событию для добавления и удаления методов-обработчиков. 
        Создайте метод Jump, выводящий на экран слово «прыгаю».
        Создайте экземпляр Human в методе Main, подпишите метод Jump на событие JumpE.
        Вызовите возникновение события JumpE.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            human.JumpE += Jump;
            human.InvokeEvent();

            Console.ReadKey();
        }

        static private void Jump()
        {
            Console.WriteLine("Jump");
        }
    }
}
