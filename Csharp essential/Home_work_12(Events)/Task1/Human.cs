using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Human
    {
        public delegate void EventDelegate();
        private event EventDelegate _jumpE = null;

        public event EventDelegate JumpE
        {
            add { _jumpE += value; }
            remove { _jumpE -= value; }
        }

        public void InvokeEvent()
        {
            _jumpE?.Invoke();
        }
    }
}
