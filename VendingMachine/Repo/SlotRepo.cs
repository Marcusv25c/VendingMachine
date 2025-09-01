using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.Repo
{
    internal class SlotRepo : ISlotRepo
    {
        private List<Slot> _slots = new List<Slot>();

        public void CreateSlots()
        {
            for (int i = 1; i <= 16; i++)
            {
                _slots.Add(new Slot(i.ToString()));
            }

            foreach (Slot slot in _slots)
            {
                Debug.WriteLine($"Slot {slot.Name}");
            }
        }
    }
}
