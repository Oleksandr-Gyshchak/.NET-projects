using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_8
{
    public enum Zodiac : byte
    {
        Овен,
        Телец,
        Близнецы,
        Рак,
        Лев,
        Дева,
        Весы,
        Скорпион,
        Стрелец,
        Козерог,
        Водолей,
        Рыбы
    }

    static class ZodiacSign
    {
        public static Zodiac GetZodiacSign(int day, int month)
        {
            Zodiac astroSign = Zodiac.Козерог;

            switch (month)
            {
                case 1:
                    astroSign = (day < 20) ? Zodiac.Козерог : Zodiac.Водолей;
                    break;
                case 2:
                    astroSign = (day < 19) ? Zodiac.Водолей : Zodiac.Рыбы;
                    break;
                case 3:
                    astroSign = (day < 21) ? Zodiac.Рыбы : Zodiac.Овен;
                    break;
                case 4:
                    astroSign = (day < 20) ? Zodiac.Овен : Zodiac.Телец;
                    break;
                case 5:
                    astroSign = (day < 21) ? Zodiac.Телец : Zodiac.Близнецы;
                    break;
                case 6:
                    astroSign = (day < 21) ? Zodiac.Близнецы : Zodiac.Рак;
                    break;
                case 7:
                    astroSign = (day < 23) ? Zodiac.Рак : Zodiac.Лев;
                    break;
                case 8:
                    astroSign = (day < 23) ? Zodiac.Лев : Zodiac.Дева;
                    break;
                case 9:
                    astroSign = (day < 23) ? Zodiac.Дева : Zodiac.Весы;
                    break;
                case 10:
                    astroSign = (day < 23) ? Zodiac.Весы : Zodiac.Скорпион;
                    break;
                case 11:
                    astroSign = (day < 22) ? Zodiac.Скорпион : Zodiac.Стрелец;
                    break;
                case 12:
                    astroSign = (day < 22) ? Zodiac.Стрелец : Zodiac.Козерог;
                    break;
            }

            return astroSign;
        }
    }
}
