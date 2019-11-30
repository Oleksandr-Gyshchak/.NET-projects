using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class OrderEventArgs : EventArgs
    {
        public string Order { get; private set; }

        public OrderEventArgs(string order)
        {
            Order = order;
        }
    }
}
