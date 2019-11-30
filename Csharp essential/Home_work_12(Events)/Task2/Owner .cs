using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Owner
    {
        public event EventHandler<OrderEventArgs> OrderToDog = null;

        public void GiveAnOrder(string str)
        {
            OrderToDog?.Invoke(this, new OrderEventArgs(str));
        }
    }
}
