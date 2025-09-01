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
        private BankRepo _bankRepo;
        private StockRepo _stockRepo = new StockRepo();

        public void ChooseProduct(int slot)
        {
            
                try
                {
                    _stockRepo.ChooseProduct(slot);
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
    }
}
