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
                byte[] itemData = new byte[5];
                bool isEmptySlot = false;
                Array.Copy(data, i, itemData, 0, 5);
                
                if (IsEmptySlot(itemData))
                {
                    i -= 3;
                    isEmptySlot = true;
                }

                var invData = GetItem(itemData, slot, slotType, isEmptySlot);
                items.Add(invData);
                slot++;

                if (GotAllSlots(slotType, slot))
                {
                    break;
                }
            }

            return items;
        }

        public static byte[] GetItemBytes(List<InventoryData> itemDatas)
        {
            List<byte> data = new List<byte>();

            foreach (var itemData in itemDatas)
            {
                if (itemData.Item.Id == 0)
                {
                    data.Add(0);
                    data.Add(0);
                    continue;
                }

                if (itemData.Item.Id == -1)
                {
                    data.AddRange(itemData.RawData);
                    continue;
                }

                data.AddRange(ConvertItemToBytes(itemData));
            }

            return data.ToArray();
        }

        private static InventoryData GetItem(byte[] itemData, ushort slot, SlotType slotType, bool isEmptySlot)
        {
            if (isEmptySlot)
            {
                return new InventoryData()
                {
                    Slot = slot,
                    SlotType = slotType
                };
            }

            var idArray = new byte[2];
            var amountArray = new byte[2];
            Array.Copy(itemData, 0, idArray, 0, 2);
            Array.Copy(itemData, 2, amountArray, 0, 2);

            return new InventoryData()
            {
                Slot = slot,
                Item = Items.GetItembyId(ConvertBytesToInt(idArray)),
                SlotType = slotType,
                Prefix = (ushort)itemData[4],
                Amount = (ushort)ConvertBytesToInt(amountArray),
                RawData = itemData
            };
        }

        private static byte[] ConvertItemToBytes(InventoryData invData)
        {
            byte[] itemData = new byte[5];

            // Convert ID
            Array.Copy(ConvertUShortToBytes(Convert.ToUInt16(invData.Item.Id)), itemData, 2);
            // Convert Amount
            Array.Copy(ConvertUShortToBytes(Convert.ToUInt16(invData.Amount)), 0, itemData, 2, 2);

            itemData[4] = (byte)invData.Prefix;

            return itemData;
        }

        private static bool GotAllSlots(SlotType slotType, int currentSlot)
        {
            switch (slotType)
            {
                case SlotType.Bar:
                    return currentSlot == 10;
                case SlotType.Inv:
                    return currentSlot == 30;
                case SlotType.Ammo:
                    return currentSlot == 4;
                case SlotType.Money:
                    return currentSlot == 4;
                default:
                    throw new ArgumentException("Invalid SlotType");
            }
        }

        private static bool IsEmptySlot(byte[] idData)
        {
            return idData[0] == 0 && idData[1] == 0;
        }

        private static int ConvertBytesToInt(byte[] idData)
        {
            if (idData[1] == 0)
            {
                return BitConverter.ToInt16(idData, 0);
            }

            Array.Reverse(idData);
            return BitConverter.ToInt16(idData, 0);
        }

        private static byte[] ConvertUShortToBytes(ushort idData)
        {
            var data = BitConverter.GetBytes(idData);
            Array.Reverse(data);
            return data;
        }
    }
}
