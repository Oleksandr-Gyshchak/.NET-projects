using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Move();

            // up cast
            Primata primate = new Primata();
            primate.Move();

            Vertebrata vertebrate = new Vertebrata();
            vertebrate.Move();

            Chordate chordate = new Chordate();
            chordate.Move();

            Animal animal = new Animal();
            animal.Move();

            
            // down cast
            Console.WriteLine("\n down cast");
            Chordate chordate2 = new Chordate();
            chordate2.Move();

            Vertebrata vertebrate2 =  new Vertebrata();
            vertebrate2.Move();

            Primata primate2 = new Primata();
            primate2.Move();

            Human human2 = new Human();
            human2.Move();
            

            Console.ReadKey();
        }
    }
}
