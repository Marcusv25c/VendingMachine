using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    internal class Slot
    {
        private string _name;
        private int _cap = 8;
        private Queue<Product> _stock = new Queue<Product>();

        public string Name { get { return _name; } set { _name = value; } }
        public Queue<Product> products { get { return _stock; } set { _stock = value; } }

        public Slot (string name)
        {
            Name = name;
        }
    }
}
