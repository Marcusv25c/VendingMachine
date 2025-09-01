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
        private Queue<Product> _slot1 = new Queue<Product>(new Product("Harboe Pils", 5));
        private Queue<Product> _slot2 = new Queue<Product>();
        private Queue<Product> _slot3 = new Queue<Product>();
        private Queue<Product> _slot4 = new Queue<Product>();
        private Queue<Product> _slot5 = new Queue<Product>();
        private Queue<Product> _slot6 = new Queue<Product>();
        private Queue<Product> _slot7 = new Queue<Product>();
        private Queue<Product> _slot8 = new Queue<Product>();

        public int ChooseProduct(int slot)
        {
            int price = 0;
            Product temp = null;
            switch (slot)
            {
                case 1:
                    {
                        try
                        {
                            temp = _slot1.Peek();
                            price = temp.Price;
                            return price;
                        }
                        catch
                        {
                            throw new Exception("Udsolgt");
                        }
                    }
                case 2:
                    {
                        try
                        {
                            temp = _slot2.Peek();
                            price = temp.Price;
                            return price;
                        }
                        catch
                        {
                            throw new Exception("Udsolgt");
                        }
                    }
                case 3:
                    {
                        try
                        {
                            temp = _slot3.Peek();
                            price = temp.Price;
                            return price;
                        }
                        catch
                        {
                            throw new Exception("Udsolgt");
                        }
                    }
                case 4:
                    {
                        try
                        {
                            temp = _slot4.Peek();
                            price = temp.Price;
                            return price;
                        }
                        catch
                        {
                            throw new Exception("Udsolgt");
                        }
                    }
                case 5:
                    {
                        try
                        {
                            temp = _slot5.Peek();
                            price = temp.Price;
                            return price;
                        }
                        catch
                        {
                            throw new Exception("Udsolgt");
                        }
                    }
                case 6:
                    {
                        try
                        {
                            temp = _slot6.Peek();
                            price = temp.Price;
                            return price;
                        }
                        catch
                        {
                            throw new Exception("Udsolgt");
                        }
                    }
                case 7:
                    {
                        try
                        {
                            temp = _slot7.Peek();
                            price = temp.Price;
                            return price;
                        }
                        catch
                        {
                            throw new Exception("Udsolgt");
                        }
                    }
                case 8:
                    {
                        try
                        {
                            temp = _slot8.Peek();
                            price = temp.Price;
                            return price;
                        }
                        catch
                        {
                            throw new Exception("Udsolgt");
                        }
                    }

                default:
                    {
                        throw new ArgumentOutOfRangeException("Valgte produkt findes ikke");
                    }
            }
        }
    }
}
