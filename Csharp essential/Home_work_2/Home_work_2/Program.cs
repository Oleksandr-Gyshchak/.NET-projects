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
            Primata primate = human;
            primate.Move();

            Vertebrata vertebrate = primate;
            vertebrate.Move();

            Chordate chordate = vertebrate;
            chordate.Move();

            Animal animal = chordate;
            animal.Move();

            
            // down cast
            Console.WriteLine("\n down cast");
            Chordate chordate2 = (Chordate)animal;
            chordate2.Move();

            Vertebrata vertebrate2 = (Vertebrata)chordate2;
            vertebrate2.Move();

            Primata primate2 = (Primata)vertebrate2;
            primate2.Move();

            Human human2 = (Human)primate2;
            human2.Move();
            

            Console.ReadKey();
        }
    }
}
