﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_2
{
    class Vertebrata: Chordate
    {

        public override void Move()
        {
            Type objectType = this.GetType();
            Console.WriteLine("Я {0}, двигаюсь в воде быстро", objectType);
        }

    }
}
