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
            Duck duck = new Duck();
            Penguin penguin = new Penguin();
            Dolphin dolphin = new Dolphin();

            duck.Move();
            duck.Eat();

            penguin.Move();
            penguin.Eat();

            dolphin.Move();
            dolphin.Eat();


            IFlyable duck2 = duck as IFlyable;
            duck2.Fly();

            IWalkable penguin2 = penguin as IWalkable;
            penguin2.Walk();

            ISwimable dolphin2 = dolphin as ISwimable;
            dolphin2.Swim();


            string direction = Direction.down.ToString();
            duck.Move(direction);

            direction = Direction.up.ToString();
            penguin.Move(direction);


            Console.ReadKey();


        }
    }
}
