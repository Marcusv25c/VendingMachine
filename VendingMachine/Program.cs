using System.Diagnostics;
using VendingMachine.Service;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service.VendingMachine _service = new Service.VendingMachine();

            Console.WriteLine($"Hello, World!\n");

            while (true)
            {
                _service.ChooseProduct(Int32.Parse(Console.ReadLine()));
            }
        }
    }
}
