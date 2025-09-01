using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.Repo
{
    internal class StockRepo
    {
        private Queue<Product> _slot1 = new Queue<Product>();
        private Queue<Product> _slot2 = new Queue<Product>();
        private Queue<Product> _slot3 = new Queue<Product>();
        private Queue<Product> _slot4 = new Queue<Product>();
        private Queue<Product> _slot5 = new Queue<Product>();
        private Queue<Product> _slot6 = new Queue<Product>();
        private Queue<Product> _slot7 = new Queue<Product>();
        private Queue<Product> _slot8 = new Queue<Product>();

        public void ChooseProduct(int slot)
        {
            switch(slot)
            {
                case 1:


                default:
                    {
                        throw new ArgumentOutOfRangeException("Valgte produkt findes ikke");
                    }
            }
        }
    }
}
