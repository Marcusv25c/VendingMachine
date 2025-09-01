using System.Diagnostics;
using VendingMachine.Repo;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SlotRepo _slotRepo = new SlotRepo();

            Console.WriteLine($"Hello, World!\n");

            _slotRepo.CreateSlots();

        }
    }
}
