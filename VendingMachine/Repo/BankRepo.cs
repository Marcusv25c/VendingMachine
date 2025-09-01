using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.Repo
{
    internal class BankRepo
    {
        private int _total;
        private Queue<Coin> _coins1 = new Queue<Coin>();
        private Queue<Coin> _coins2 = new Queue<Coin>();
        private Queue<Coin> _coins5 = new Queue<Coin>();
        private Queue<Coin> _coins10 = new Queue<Coin>();
        private Queue<Coin> _coins20 = new Queue<Coin>();

        public void ReceivePayment(List<int> received)
        {
            foreach (int value in received)
            {
                switch (value)
                {
                    case 1:
                        {
                            _coins1.Enqueue(new Coin(value));
                            break;
                        }
                    case 2:
                        {
                            _coins2.Enqueue(new Coin(value));
                            break;
                        }
                    case 5:
                        {
                            _coins5.Enqueue(new Coin(value));
                            break;
                        }
                    case 10:
                        {
                            _coins10.Enqueue(new Coin(value));
                            break;
                        }
                    case 20:
                        {
                            _coins20.Enqueue(new Coin(value));
                            break;
                        }
                }// switch end
                _total += value;

            }// foreach end



        }
    }
}
