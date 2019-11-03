using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string msgInputDateOfBirth = "Введите дату рождения format: dd.MM.yyyy ";
            string dateFormat = "dd.MM.yyyy";

            Console.WriteLine(msgInputDateOfBirth);

            try
            {
                string dateString = Console.ReadLine();

                DateTime dateOfBirth = DateTime.ParseExact(dateString, dateFormat, System.Globalization.CultureInfo.InvariantCulture);

                if (dateOfBirth >= DateTime.Now) throw new Exception();


                var zodiac = ZodiacSign.GetZodiacSign(dateOfBirth.Day, dateOfBirth.Month);
                Console.WriteLine(zodiac);
            }
            catch
            {
                Console.WriteLine("Invalid Date");
            }

            Console.ReadKey();
        }
    }
}
