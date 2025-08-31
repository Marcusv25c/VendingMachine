using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Repo;

namespace VendingMachine.Model
{
    internal class VendingMachine
    {
        private ISlotRepo _slotRepo = new SlotRepo();
        private List<Slot> _slots = new List<Slot>();

        public void CreateSlots()
        {
            _slotRepo.CreateSlots();
        }
    }
}
