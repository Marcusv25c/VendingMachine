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
        
        private int _cap = 8;
        private Queue<Product> _slot1 = new Queue<Product>();
        private Queue<Product> _slot2 = new Queue<Product>();
        private Queue<Product> _slot3 = new Queue<Product>();
        private Queue<Product> _slot4 = new Queue<Product>();
        private Queue<Product> _slot5 = new Queue<Product>();
        private Queue<Product> _slot6 = new Queue<Product>();
        private Queue<Product> _slot7 = new Queue<Product>();
        private Queue<Product> _slot8 = new Queue<Product>();

        public StockRepo()
        {
            while (_slot1.Count < _cap)
            {
                _slot1.Enqueue(new Product("Harboe Pils", 5));  
            }
            _slot2.Enqueue(new Product("Harboe Pils", 5));
        }
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

        public void ExtractProduct(int slot)
        {
            switch (slot)
            {
                case 1:
                    {
                       Product toExtract = _slot1.Dequeue();
                        Console.WriteLine($"Her er din {toExtract.Name}");
                        break;
                    }
                case 2:
                    {
                        Product toExtract = _slot2.Dequeue();
                        Console.WriteLine($"Her er din {toExtract.Name}");
                        break;
                    }
                case 3:
                    {
                        Product toExtract = _slot3.Dequeue();
                        Console.WriteLine($"Her er din {toExtract.Name}");
                        break;
                    }
                case 4:
                    {
                        Product toExtract = _slot4.Dequeue();
                        Console.WriteLine($"Her er din {toExtract.Name}");
                        break;
                    }
                case 5:
                    {
                        Product toExtract = _slot5.Dequeue();
                        Console.WriteLine($"Her er din {toExtract.Name}");
                        break;
                    }
                case 6:
                    {
                        Product toExtract = _slot6.Dequeue();
                        Console.WriteLine($"Her er din {toExtract.Name}");
                        break;
                    }
                case 7:
                    {
                        Product toExtract = _slot7.Dequeue();
                        Console.WriteLine($"Her er din {toExtract.Name}");
                        break;
                    }
                case 8:
                    {
                        Product toExtract = _slot8.Dequeue();
                        Console.WriteLine($"Her er din {toExtract.Name}");
                        break;
                    }
            }
        }


        public List<string> FillAll()
        {
            int counter = 0;
            List<string> info = new List<string>();

            while (_slot1.Count < _cap)
            {
                _slot1.Enqueue(new Product("Harboe Pils", 5));
                counter++;
            }
            info.Add($"Hylde 1 opfyldt med: {counter.ToString()}x Harboe Pils");
            counter = 0;

            while (_slot2.Count < _cap)
            {
                _slot2.Enqueue(new Product("Harboe Pils", 5));
                counter++;
            }
            info.Add($"Hylde 2 opfyldt med: {counter.ToString()}x Harboe Pils");
            counter = 0;

            while (_slot3.Count < _cap)
            {
                _slot3.Enqueue(new Product("Classic", 12));
                counter++;
            }
            info.Add($"Hylde 3 opfyldt med: {counter.ToString()}x Classic");
            counter = 0;

            while (_slot4.Count < _cap)
            {
                _slot4.Enqueue(new Product("Classic", 12));
                counter++;
            }
            info.Add($"Hylde 4 opfyldt med: {counter.ToString()}x Classic");
            counter = 0;

            while (_slot5.Count < _cap)
            {
                _slot5.Enqueue(new Product("Gulddame", 27));
                counter++;
            }
            info.Add($"Hylde 5 opfyldt med: {counter.ToString()}x Gulddame");
            counter = 0;

            while (_slot6.Count < _cap)
            {
                _slot6.Enqueue(new Product("Gulddame", 27));
                counter++;
            }
            info.Add($"Hylde 6 opfyldt med: {counter.ToString()}x Gulddame");
            counter = 0;

            while (_slot7.Count < _cap)
            {
                _slot7.Enqueue(new Product("Liquid Death", 15));
                counter++;
            }
            info.Add($"Hylde 7 opfyldt med: {counter.ToString()}x Liquid Death");
            counter = 0;

            while (_slot8.Count < _cap)
            {
                _slot8.Enqueue(new Product("Liquid Death", 15));
                counter++;
            }
            info.Add($"Hylde 8 opfyldt med: {counter.ToString()}x Liquid Death");
            counter = 0;



            return info;
        }
    }


}
