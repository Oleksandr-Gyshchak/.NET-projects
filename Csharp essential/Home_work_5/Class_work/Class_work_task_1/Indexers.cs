using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work_task_1
{
    class Indexers
    {
        private int[] numbers = new int[10];

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index <= numbers.Length)
                {
                    return numbers[index];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                numbers[index] = value;
            }
        }
    }
}
