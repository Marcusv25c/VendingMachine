using System.Diagnostics;
using VendingMachine.Repo;
using VendingMachine.Service;

namespace VendingMachine
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Service.VendingMachine _service = new Service.VendingMachine();
            string input = "";

            while (input != "x")
            {
                Console.WriteLine($"Got Beer?!\n");
                Console.WriteLine($"Vælg produkt: \n  1-2: Harboe Pils \n  3-4: Grøn Tuborg \n  5-6: Hoegaarden \n  7-8: Hobgoblin\n");

                input = Console.ReadLine();

                if(input  == "x")
                {
                    break;
                }
                //Indsæt try.. catch
                _service.ChooseProduct(Int32.Parse(input));
            }

            Console.Clear();
            Main(args);
        }

        //static void Admin()
        //{
        //    Service.VendingMachine _service = new Service.VendingMachine();

        //    Console.WriteLine($"Vælg funktion: \n  1: Fyld varer \n  2: Tøm pengebeholder \n  9: Tilbage til menu \n");
        //    string input = Console.ReadLine();

        //    switch (input)
        //    {
        //        case 1:
        //            {
        //                _service.FillAll();
        //                break; 
        //            }
        //        case 2:
        //            {
        //                _service.EmptyBank();
        //                break;
        //            }
        //        case 9:
        //            {
        //                Main(args);

        //            }
        //    }
        //}
    }
}
