using System.Diagnostics;
using VendingMachine.Repo;
using VendingMachine.Service;

namespace VendingMachine
{
    internal class Program
    {
        public static Service.VendingMachine _service = new Service.VendingMachine();

        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
            
        }

        static void Menu()
        {
            string input = "";

            while (input != "x")
            {
                Console.WriteLine($"Got Beer?!\n");
                Console.WriteLine($"Vælg produkt: \n  1-2: Harboe Pils \n  3-4: Classic \n  5-6: Gulddame \n  7-8: Liquid Death\n");

                input = Console.ReadLine();

                if (input == "x")
                {
                    break;
                }
                if (input == "admin")
                {
                    Admin();
                }
                //Indsæt try.. catch
                _service.ChooseProduct(Int32.Parse(input));

                input = Console.ReadLine();
                if (input == "tak")
                {
                    Console.WriteLine("Selv tak");
                    Thread.Sleep(500);
                }

                Console.Clear();
            }

        }

        static void Admin()
        {
            string input = "";

            while (input != "x")
            { 
                Console.WriteLine($"Vælg funktion: \n  1: Fyld varer \n  2: Fyld pengebeholder \n  9: Tilbage til menu \n");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        {
                            foreach (string slot in _service.FillAll())
                            {
                                Console.WriteLine(slot);
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine(_service.FillBank());
                            break;
                        }
                    case "9":
                        {
                            Console.Clear();
                            Menu();
                            break;
                        }
                }
            }

            
        }
    }
}
