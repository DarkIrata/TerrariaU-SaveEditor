using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrariaUSaveEditor.Helper;

namespace TerrariaUSaveEditor
{
    public enum Gender
    {
        Female = 0,
        Male = 1
    }

    public enum Difficutly
    {
        Normal = 0,
        Hard = 1,
        Hardcore = 2
    }

    public class SaveHandler
    {
        public byte[] RawSave { get; set; }
        public string SavePath { get; set; }
        

        internal void LoadSave(string path)
        {
            this.SavePath = path;
            this.RawSave = File.ReadAllBytes(path);
            this.DetermineNameLength();
        }

        internal void SaveSave()
        {
            var path = Path.GetDirectoryName(this.SavePath);
            var fileNameFilter = $"*{Path.GetFileName(this.SavePath)}.bak*";
            int bakNum = Directory.GetFiles(path, fileNameFilter, SearchOption.TopDirectoryOnly).Length;

            File.Move(this.SavePath, this.SavePath + ".BAK" + bakNum);
            File.WriteAllBytes(this.SavePath, this.RawSave);
        }

        private void DetermineNameLength()
        {
            OffsetHelper.NameLength = this.RawSave[OffsetHelper.NameLengthInformation];
        }

        internal string GetPlayerName()
        {
            var buffer = new byte[16];
            Buffer.BlockCopy(this.RawSave, OffsetHelper.Name, buffer, 0, OffsetHelper.NameLength);
            return Encoding.UTF8.GetString(buffer);
        }

        internal void SetPlayerName(string name)
        {
            var newName = Encoding.UTF8.GetBytes(name);
            this.RawSave = ArrayHelper.RemoveRange(this.RawSave, OffsetHelper.Name, OffsetHelper.NameLength);
            this.RawSave = ArrayHelper.AddRangeAtIndex(this.RawSave, newName, OffsetHelper.Name);
            this.RawSave[OffsetHelper.NameLengthInformation] = (byte)newName.Length;
            this.DetermineNameLength();
        }

        internal Gender GetGender()
        {
            var buffer = new byte[1];
            Buffer.BlockCopy(this.RawSave, OffsetHelper.Gender, buffer, 0, buffer.Length);

            return (Gender)Enum.Parse(typeof(Gender), buffer[0].ToString());
        }

        internal void SetGender(Gender gender)
        {
            this.RawSave[OffsetHelper.Gender] = (byte)gender;
        }

        internal Difficutly GetDifficutly()
        {
            var buffer = new byte[1];
            Buffer.BlockCopy(this.RawSave, OffsetHelper.Difficutly, buffer, 0, buffer.Length);

            return (Difficutly)Enum.Parse(typeof(Difficutly), buffer[0].ToString());
        }

        internal void SetDifficutly(Difficutly difficutly)
        {
            this.RawSave[OffsetHelper.Difficutly] = (byte)difficutly;
        }

        internal List<Color> GetColors()
        {
            var buffer = new byte[21];
            Buffer.BlockCopy(this.RawSave, OffsetHelper.HairColor, buffer, 0, (OffsetHelper.ShoesColor - OffsetHelper.HairColor) + 3);

            List<Color> colors = new List<Color>();
            for (int i = 0; i < buffer.Length; i += 3)
            {
                colors.Add(Color.FromArgb(buffer[i], buffer[i + 1], buffer[i + 2]));
            }

            return colors;
        }

        internal void SetColors(List<Color> colors)
        {
            var buffer = new byte[21];

            for (int i = 0; i < colors.Count; i++)
            {
                var newColor = ArrayHelper.ColorToByteArray(colors[i]);
                if (i == 0)
                {
                    Array.Copy(newColor, 0, buffer, i, newColor.Length);
                    continue;
                }
                Array.Copy(newColor, 0, buffer, i * 3, newColor.Length);
            }
            
            this.RawSave = ArrayHelper.RemoveRange(this.RawSave, OffsetHelper.HairColor, (OffsetHelper.ShoesColor - OffsetHelper.HairColor) + 3);
            this.RawSave = ArrayHelper.AddRangeAtIndex(this.RawSave, buffer, OffsetHelper.HairColor);
        }

        internal void SetInventory(Dictionary<SlotType, List<InventoryData>> inventory)
        {
            var barData = (ItemHelper.GetItemBytes(inventory[SlotType.Bar]));
            var invData = (ItemHelper.GetItemBytes(inventory[SlotType.Inv]));
            var moneyData = (ItemHelper.GetItemBytes(inventory[SlotType.Money]));
            var ammoData = (ItemHelper.GetItemBytes(inventory[SlotType.Ammo]));

            byte[] buffer = new byte[barData.Length + invData.Length + moneyData.Length + ammoData.Length];
            Array.Copy(barData, 0, buffer, 0, barData.Length);
            Array.Copy(invData, 0, buffer, barData.Length, invData.Length);
            Array.Copy(moneyData, 0, buffer, barData.Length + invData.Length, moneyData.Length);
            Array.Copy(ammoData, 0, buffer, barData.Length + invData.Length + moneyData.Length, ammoData.Length);
            this.RawSave = ArrayHelper.RemoveRange(this.RawSave, OffsetHelper.Inventory, OffsetHelper.InventoryLength);
            this.RawSave = ArrayHelper.AddRangeAtIndex(this.RawSave, buffer, OffsetHelper.Inventory);
            OffsetHelper.InventoryLength = buffer.Length;
        }

        internal Dictionary<SlotType, List<InventoryData>> GetInventory()
        {
            Dictionary<SlotType, List<InventoryData>> inventory = new Dictionary<SlotType, List<InventoryData>>();

            var barItems = GetBarItems();
            inventory.Add(SlotType.Bar, barItems);

            var diffOffset = OffsetHelper.CalcOffsetDiffInventory(barItems);
            var invItems = GetInvItems(diffOffset);
            inventory.Add(SlotType.Inv, invItems);

            diffOffset += OffsetHelper.CalcOffsetDiffInventory(invItems);
            var moneyItems = GetMoneyItems(diffOffset);
            inventory.Add(SlotType.Money, moneyItems);

            diffOffset += OffsetHelper.CalcOffsetDiffInventory(moneyItems);
            var ammoItems = GetAmmoItems(diffOffset);
            inventory.Add(SlotType.Ammo, ammoItems);

            OffsetHelper.InventoryLength = diffOffset + OffsetHelper.CalcOffsetDiffInventory(ammoItems);
            return inventory;
        }

        private List<InventoryData> GetBarItems()
        {
            var buffer = new byte[50];
            Buffer.BlockCopy(this.RawSave, OffsetHelper.Inventory, buffer, 0, buffer.Length);

            return ItemHelper.GetItems(buffer, SlotType.Bar);
        }

        private List<InventoryData> GetInvItems(int offsetDiff)
        {
            var buffer = new byte[250];
            Buffer.BlockCopy(this.RawSave, OffsetHelper.Inventory + offsetDiff, buffer, 0, buffer.Length);

            return ItemHelper.GetItems(buffer, SlotType.Inv);
        }

        private List<InventoryData> GetMoneyItems(int offsetDiff)
        {
            var buffer = new byte[20];
            Buffer.BlockCopy(this.RawSave, OffsetHelper.Inventory + offsetDiff, buffer, 0, buffer.Length);

            return ItemHelper.GetItems(buffer, SlotType.Money);
        }

        private List<InventoryData> GetAmmoItems(int offsetDiff)
        {
            var buffer = new byte[20];
            Buffer.BlockCopy(this.RawSave, OffsetHelper.Inventory + offsetDiff, buffer, 0, buffer.Length);

            return ItemHelper.GetItems(buffer, SlotType.Ammo);
        }
    }
}
