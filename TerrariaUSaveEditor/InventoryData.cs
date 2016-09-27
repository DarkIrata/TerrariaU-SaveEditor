using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrariaUSaveEditor.GameData;

namespace TerrariaUSaveEditor
{
    public enum SlotType
    {
        Bar,
        Inv,
        Ammo,
        Money
    }

    public class InventoryData
    {
        public ushort Slot { get; set; }

        public SlotType SlotType { get; set; }

        public ItemData Item { get; set; }

        public int Prefix { get; set; }

        public ushort Amount { get; set; }

        public InventoryData()
        {
            this.Item = Items.GetItembyId(0);
            this.Prefix = 0;
            this.Amount = 0;
        }

        public InventoryData(ushort slot, SlotType slotType)
            : this()
        {
            this.Slot = slot;
            this.SlotType = slotType;
        }
    }
}
