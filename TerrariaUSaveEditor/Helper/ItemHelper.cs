using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrariaUSaveEditor.GameData;

namespace TerrariaUSaveEditor.Helper
{
    public static class ItemHelper
    {
        public static List<InventoryData> GetItems(byte[] data, SlotType slotType)
        {
            List<InventoryData> items = new List<InventoryData>();
            ushort slot = 0;

            for (int i = 0; i < data.Length; i+=5)
            {
                var idArray = new byte[2];
                Array.Copy(data, i, idArray, 0, 2);

                if (IsEmptySlot(idArray))
                {
                    i -= 3;
                }

                int id = GetIDFromBytes(idArray);

                items.Add(new InventoryData()
                {
                    Slot = slot,
                    Item = Items.GetItembyId(id),
                    SlotType = slotType,
                    Prefix = (ushort)data[i + 4],
                    Amount = (ushort)data[i + 3]
                });
                
                slot++;

                if (GotAllSlots(slotType, slot))
                {
                    break;
                }
            }

            return items;
        }

        private static bool GotAllSlots(SlotType slotType, int currentSlot)
        {
            switch (slotType)
            {
                case SlotType.Bar:
                    return currentSlot == 10 ? true : false;
                case SlotType.Inv:
                    return currentSlot == 30 ? true : false;
                case SlotType.Ammo:
                    return currentSlot == 4 ? true : false;
                case SlotType.Money:
                    return currentSlot == 4 ? true : false;
                default:
                    throw new ArgumentException("Invalid SlotType");
            }
        }

        private static bool IsEmptySlot(byte[] idData)
        {
            if (idData[0] == 0 &&
                idData[1] == 0)
            {
                return true;
            }

            return false;
        }

        private static int GetIDFromBytes(byte[] idData)
        {
            if (idData[1] == 0)
            {
                return BitConverter.ToInt16(idData, 0);
            }

            Array.Reverse(idData);
            return BitConverter.ToInt16(idData, 0);
        }
    }
}
