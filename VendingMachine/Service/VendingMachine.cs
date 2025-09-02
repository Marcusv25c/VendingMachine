using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Repo;

namespace VendingMachine.Service
{
    internal class VendingMachine
    {
        private int _price;
        private List<int> _paid = new List<int>();
        private int _paidSum = 0;
        private BankRepo _bankRepo = new BankRepo();
        private StockRepo _stockRepo = new StockRepo();

        public void ChooseProduct(int slot)
        {
            
                try
                {
                    _price = _stockRepo.ChooseProduct(slot);
                    if (_price != null);
                    {
                    Console.WriteLine($"Indsæt mønter: {_price} kr.");
                    }
                }

                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Pladsen findes ikke");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            Payment();

            _stockRepo.ExtractProduct(slot);

        }

        public void Payment()
        {
            while (_paidSum < _price)
            {
                //try.. catch here
                int newCoin = Int32.Parse(Console.ReadLine());
                if (newCoin == 1 || newCoin == 2 || newCoin == 5 || newCoin == 10 || newCoin == 20 )
                {
                    _paidSum += newCoin;
                    _paid.Add(newCoin);
                }

                else
                {
                    Console.WriteLine("Ugyldigt mønt");
                }
            }

            _bankRepo.ReceivePayment(_paid);


            //if (_paidSum > _price)
            //{
            //    _bankRepo.GiveChange(_paidSum - _price);
            //}
            _paid = new List<int>();
            _paidSum = 0;
        }
    }
}
