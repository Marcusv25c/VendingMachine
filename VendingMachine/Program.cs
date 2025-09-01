using System.Diagnostics;
using VendingMachine.Service;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service.VendingMachine _service = new Service.VendingMachine();
            string input = "";

            Console.WriteLine($"Got Beer?!\n");
            Console.WriteLine($"Vælg produkt: \n  1-2: Harboe Pils \n  3-4: Grøn Tuborg \n  5-6: Hoegaarden \n  7-8: Hobgoblin\n");

            while (input != "x")
            {
                input = Console.ReadLine();
                //Indsæt try.. catch
                _service.ChooseProduct(Int32.Parse(input));
            }
        }
    }
}
