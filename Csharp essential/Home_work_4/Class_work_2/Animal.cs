using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work_2
{
    abstract class Animal
    {
        public abstract void Eat();
        public abstract void Move(string direction = null);
    }

    abstract class Bird : Animal
    {
    }

    abstract class Mammal : Animal
    {
    }

    abstract class Fish : Animal
    {
    }

    interface ISwimable
    {
        void Swim();
    }

    interface IFlyable
    {
        void Fly();
    }

    interface IWalkable
    {
        void Walk();
    }


    class Duck : Bird, IFlyable
    {
        public override void Eat()
        {
            Console.WriteLine("Duck eat");
        }

        public override void Move(string direction = null)
        {
            Console.WriteLine($"Duck move {direction}");
        }


        public void Fly()
        {
            Console.WriteLine("Duck fly");
        }
    }

    class Penguin : Mammal, IWalkable
    {
        public override void Eat()
        {
            Console.WriteLine("Penguin eat");
        }

        public override void Move(string direction = null)
        {
            Console.WriteLine($"Penguin move {direction}");
        }


        public void Walk()
        {
            Console.WriteLine("Duck walk");
        }
    }

    class Dolphin : Fish, ISwimable
    {
        public override void Eat()
        {
            Console.WriteLine("Dolphin eat");
        }

        public override void Move(string direction = null)
        {
            Console.WriteLine($"Dolphin move {direction}");
        }


        public void Swim()
        {
            Console.WriteLine("Dolphin Swim");
        }
    }

    enum Direction
    {
        left,
        right,
        up,
        down
    }

}

