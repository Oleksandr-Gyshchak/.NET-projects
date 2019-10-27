using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work_1
{
    class Smartphone : Computer, IPhone, IVidioPayer, IEditor
    {
        public Smartphone(int length, string processor, string memory)
            : base(length, processor, memory)
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine($"length  = {length}, processor = {processor}, memory = {memory}");
        }
        public void CanCall()
        {
            Console.WriteLine("Can Call");
        }

        public void CanShowVidio()
        {
            Console.WriteLine("Can Show Vidio");
        }

        public void CanEdit()
        {
            Console.WriteLine("Can Edit SMS");
        }

        public override void CanDo()
        {
            CanCall();
            CanShowVidio();
            CanEdit();
        }
    }
}
