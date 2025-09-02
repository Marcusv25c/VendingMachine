using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    internal class Coin
    {
        private int _value;

        public int Value { get; private set; }

        public Coin(int value)
        {
            _value = value;
        }
    }
}
