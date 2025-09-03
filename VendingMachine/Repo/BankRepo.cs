using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        //public BankRepo()
        //{
        //    while (_coins1.Count < 10)
        //    {
        //        _coins1.Enqueue(new Coin(1));
        //        Debug.WriteLine($"BankRepo: {_coins1.Count}");
        //    }

        //    while(_coins2.Count < 10)
        //    {
        //        _coins2.Enqueue(new Coin(2));
        //    }

        //    while(_coins5.Count < 10)
        //    {
        //        _coins5.Enqueue(new Coin(5));
        //    }

        //    while(_coins10.Count < 10)
        //    {
        //        _coins10.Enqueue(new Coin(10));
        //    }


        //}

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
                            Debug.WriteLine($"coiins5: {_coins5.Count}");
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

        public List<int> GiveChange(int amount)
        {
            List<int> coins = new List<int>();
            Debug.WriteLine($"GiveChange: coins10: {_coins10.Count}");
            while (amount > 0)
            {

                if (amount > 9)
                {
                    Debug.WriteLine($"amount > 9");
                    Coin temp = _coins10.Dequeue();
                    Debug.WriteLine($"temp: {temp.Value}");
                    coins.Add(temp.Value);
                    amount -= temp.Value;
                    Debug.WriteLine($"amount: {amount}");
                }

                if (amount > 4)
                {
                    Coin temp = _coins5.Dequeue();
                    coins.Add(temp.Value);
                    amount -= temp.Value;
                }

                if (amount > 1)
                {
                    Coin temp = _coins2.Dequeue();
                    coins.Add(temp.Value);
                    amount -= temp.Value;
                }

                if (amount == 1)
                {
                    Coin temp = _coins1.Dequeue();
                    coins.Add(temp.Value);
                    amount -= temp.Value;
                }

            }//While end

            return coins;


        }

        public string FillBank()
        {
            while (_coins1.Count < 20)
            {
                _coins1.Enqueue(new Coin(1));
            }

            while (_coins2.Count < 10)
            {
                _coins2.Enqueue(new Coin(2));
            }

            while (_coins5.Count < 10)
            {
                _coins5.Enqueue(new Coin(5));
            }

            while (_coins10.Count < 10)
            {
                _coins10.Enqueue(new Coin(10));
            }

            return "pengebeholder fyldt";
        }

    }
}
