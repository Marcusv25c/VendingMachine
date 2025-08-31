using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    internal class Product
    {
        private string _name;
        private int _price;

        protected string Name { get { return _name; } set { _name = value; } }
        protected int Price { get { return _price; } set { _price = value; } }

        public Product (string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
