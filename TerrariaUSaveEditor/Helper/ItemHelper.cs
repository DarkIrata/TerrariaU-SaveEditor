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

                data.AddRange(ConvertItemToByteData(itemData));
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
            Array.Copy(itemData, 0, idArray, 0, 2);
            int id = GetIDFromBytes(idArray);

            return new InventoryData()
            {
                Slot = slot,
                Item = Items.GetItembyId(id),
                SlotType = slotType,
                Prefix = (ushort)itemData[4],
                Amount = (ushort)itemData[3],
                RawData = itemData
            };
        }

        private static byte[] ConvertItemToByteData(InventoryData invData)
        {
            byte[] itemData = new byte[5];

            Array.Copy(GetBytesFromId(Convert.ToInt16(invData.Item.Id)), itemData, 2);
            // Currently unkown Byte
            itemData[2] = 00;
            // 
            itemData[3] = (byte)invData.Amount;
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

        private static int GetIDFromBytes(byte[] idData)
        {
            if (idData[1] == 0)
            {
                return BitConverter.ToInt16(idData, 0);
            }

            Array.Reverse(idData);
            return BitConverter.ToInt16(idData, 0);
        }

        private static byte[] GetBytesFromId(short idData)
        {
            if (idData > 255)
            {
                return BitConverter.GetBytes(idData);
            }

            var data = BitConverter.GetBytes(idData);
            Array.Reverse(data);
            return data;
        }
    }
}
