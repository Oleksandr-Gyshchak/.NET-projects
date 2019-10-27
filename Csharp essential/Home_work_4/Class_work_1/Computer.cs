using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work_1
{
    abstract class Computer
    {
        public int length { get; set; }
        public string processor { get; set; }
        public string memory { get; set; }

        public Computer(int length, string processor, string memory)
        {
            this.length = length;
            this.processor = processor;
            this.memory = memory;
        }

        public abstract void CanDo();
    }
}
