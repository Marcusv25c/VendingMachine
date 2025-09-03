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
                    
                    Console.WriteLine($"Indsæt mønter: {_price} kr.");
                    Payment();

                    _stockRepo.ExtractProduct(slot);
                }

                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Pladsen findes ikke");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                      

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


            if (_paidSum > _price)
            {
                List<int> change = _bankRepo.GiveChange(_paidSum - _price);
                Console.WriteLine("Byttepenge: ");

                foreach (int coin in change)
                {
                    Console.Write($"{coin}   ");
                }
                Console.WriteLine();
            }
            _paid = new List<int>();
            _paidSum = 0;
        }

        public List<string> FillAll()
        {
            return _stockRepo.FillAll();
        }

        public string FillBank()
        {
            return _bankRepo.FillBank();
        }

    }
}
