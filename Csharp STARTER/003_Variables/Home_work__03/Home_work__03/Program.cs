using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work__03
{
    class Program
    {

        static void Main(string[] args)
        {
            Task1();
            pressAnyButtonToContinue();

            Task2();
            pressAnyButtonToContinue();

            Task3();
            pressAnyButtonToContinue();
      
            Task4();

            Console.ReadKey();
        }

        static void Task1()
        {
            int x = 10,
                y = 12,
                z = 3;

            Console.WriteLine("Task 1");

            Console.WriteLine($"Variables : x = {x}, y = {y}, z = {z}");

            x += y - x++ * z;
            Console.WriteLine($"Action: x += y - x++ * z \n Result= {x}");

            z = --x - y * 5;
            Console.WriteLine($"Action: z = --x - y * 5 \n Result = {z}");

            y /= x + 5 % z;
            Console.WriteLine($"Action:y /= x + 5 % z \n Result= {y}");

            z = x++ + y * 5;
            Console.WriteLine($"Action: x++ + y * 5 \n Result= {z}");

            z = y - x++ * 5;
            Console.WriteLine($"Action: y - x++ * 5 \n Result= {z}");
        }

        static void Task2()
        {
            double a = 0,
                b = 0,
                c = 0;

            double averageOf3Int;
            string averageMsg = "Среднее арифметическое ";

            Console.WriteLine($"{averageMsg} 3-х чисел");

            for (int i=0; i< 3; i++)
            {
                if ( i == 0 )
                {
                    a = isInteger(i);

                } else if ( i == 1) {
                    b = isInteger(i);
                } else
                {
                    c = b = isInteger(i);
                }
            }

            averageOf3Int = (a + b + c) / c;

            Console.WriteLine($"{averageMsg} {a}, {b}, {c} равно  {averageOf3Int}");
        }

        static int isInteger(int numberCount = 0)
        {
            string msgInputInteger = $"Введите целое число № {numberCount+1}";
            string msgNotInt = "Вы ввели не целое число !!";

            int result = 0;

            while ( result == 0 )
            {
                try
                {
                    Console.WriteLine(msgInputInteger);

                    result = int.Parse( Console.ReadLine() );
                } catch
                {
                    Console.WriteLine(msgNotInt);
                }
            }
            return result;
        }


        static double isDouble(string msg)
        {
            string msgNotDouble = "Вы ввели не число !!";

            double result = 0;

            while (result == 0)
            {
                try
                {
                    Console.WriteLine(msg);

                    result = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(msgNotDouble);
                }
            }
            return result;
        }
        
        static void Task3()
        {
            string radiusMsg = "Введите радиус круга ";

            Console.WriteLine("Площадь круга");

            double radius = isDouble(radiusMsg);

            double pi = Math.PI;
            int powerCount = 2;

            double area = pi * Math.Pow(radius, powerCount);

            Console.WriteLine("Площадь круга - {0:0.00}", area);
        }


        static void Task4()
        {
            string cylinderRadiusMsg = "Введите радиус цилиндра";
            string cylinderHeightMsg = "Введите высоту цилиндра";

            string cylinderVolumeMsg = "Объем цилиндра";
            string cylinderAreaMsg = "Объем цилиндра";

            double pi = Math.PI;
            double cylinderRadius;
            double cylinderHeight;

            double cylinderVolume;
            double cylinderArea;

            Console.WriteLine($"{cylinderVolumeMsg}, {cylinderAreaMsg} \n");

            cylinderRadius = isDouble(cylinderRadiusMsg);
            cylinderHeight = isDouble(cylinderHeightMsg);

            cylinderVolume = pi * Math.Pow(cylinderRadius, 2) * cylinderHeight;
            cylinderArea = 2 * pi * cylinderRadius * (cylinderHeight + cylinderHeight);


            string formatedCylinderVolume = String.Format("{0:0.00}", cylinderVolume);
            Console.WriteLine($"{cylinderVolumeMsg} - {formatedCylinderVolume}");

            string formatedCylinderArea = String.Format("{0:0.00}", cylinderArea);
            Console.WriteLine($"{cylinderAreaMsg} - {formatedCylinderArea}");
        }

        static void pressAnyButtonToContinue()
        {

            string msg = "Нажмите любую клавишу, что бы перейти к следующему заданию";

            Console.WriteLine(msg);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
