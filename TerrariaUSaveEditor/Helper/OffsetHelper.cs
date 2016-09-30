using System;
using System.Collections.Generic;

namespace TerrariaUSaveEditor.Helper
{
    public static class OffsetHelper
    {
        // Name length change all offsets.
        public static int NameLength { get; set; }

        // Empty slots get written as "00 00". Used slots uses 5 bytes. "ID ID AMOUNT AMOUNT PREFIX"
        // Accessories (used) takes 3 Bytes. "ID ID PREFIX" currently unsure about space in inventory.

        public static int InventoryLength { get; set; }

        private static int OffsetDiff => Name + NameLength;

        // Character Offsets
        public static int NameLengthInformation => 0x02;
        public static int Name => 0x03;
        public static int Difficutly => OffsetDiff + 0x00;
        public static int Gender => OffsetDiff + 0x02;

        // Color Offsets
        public static int HairColor => OffsetDiff + 0x0B;
        public static int BodyColor => HairColor + 0x03;
        public static int EyeColor => BodyColor + 0x03;
        public static int ShirtColor => EyeColor + 0x03;
        public static int UnderShirtColor => ShirtColor + 0x03;
        public static int PantsColor => UnderShirtColor + 0x03;
        public static int ShoesColor => PantsColor + 0x03;

        // Equip Offsets
        /*
         * Equip get saved right after Colors. 1 Accessory take 3 Bytes "ID ID ?PREFIX?"
         * Again 2 Bytes as "00 00" if the slot is empty. 
         * Based on this informations for accessory's, equipable items like armor should behave the same.
         * */

        // Inventory Offsets
        public static int Inventory => OffsetDiff + 0x03D;

        public static int CalcOffsetDiffInventory(List<InventoryData> invData)
        {
            int usedSlots = 0;
            int emptySlots = 0;
            foreach (var item in invData)
            {
                if (item.Item.Id != 0)
                {
                    usedSlots++;
                }
                else
                {
                    emptySlots++;
                }
            }

            return (emptySlots * 2) + (usedSlots * 5);
        }
    }
}
