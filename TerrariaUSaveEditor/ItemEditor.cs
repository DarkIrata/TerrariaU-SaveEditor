using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerrariaUSaveEditor.GameData;
using System.Diagnostics;

namespace TerrariaUSaveEditor
{
    public partial class ItemEditor : UserControl
    {
        private string Node { get; set; }
        private InventoryData invData { get; set; }

        public ItemEditor()
        {
            this.InitializeComponent();
            this.SwitchControlStatus(false);

            var itemNameAutoCompleteList = new AutoCompleteStringCollection();
            itemNameAutoCompleteList.AddRange(Items.ItemList.Values.Select(x => x.Name).ToArray());
            this.TxtItemName.AutoCompleteCustomSource = itemNameAutoCompleteList;

            foreach (var prefix in Prefixes.PrefixList)
            {
                this.CbPrefix.Items.Add(prefix);
            }
            this.CbPrefix.DisplayMember = "value";
            this.CbPrefix.ValueMember = "key";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int prefixID = 0;
            int.TryParse(this.CbPrefix.SelectedText, out prefixID);

            this.invData.Amount = ushort.Parse(this.NudAmount.Value.ToString());
            this.invData.Prefix = prefixID;
            this.invData.Item.Id = ushort.Parse(this.NudItemId.Value.ToString());
            this.invData.Item.Name = this.TxtItemName.Text;
        }

        private void NudItemId_ValueChanged(object sender, EventArgs e)
        {
            var item = Items.GetItembyId(int.Parse(this.NudItemId.Value.ToString()));

            this.TxtItemName.Text = item.Name;
            this.CbPrefix.SelectedIndex = 0;
            this.NudAmount.Value = 0;
            if (item.Id > -1)
            {
                this.NudAmount.Value = 1;
            }
        }
        
        public void LoadInventoryItem(InventoryData data)
        {
            this.invData = data;
            this.NudItemId.Value = data.Item.Id;
            this.NudAmount.Value = data.Amount;
            this.TxtItemName.Text = data.Item.Name;
            this.CbPrefix.SelectedIndex = data.Prefix;

            this.Node = data.SlotType.ToString() + data.Slot;
            this.SwitchControlStatus(true);
        }
                
        private void SwitchControlStatus(bool enabled)
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = enabled;
            }
        }

        private void UrlLblItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://terraria.gamepedia.com/Item_IDs");
        }

        private void UrlLblPrefixes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://terraria.gamepedia.com/Prefix_IDs");
        }

        private void TxtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var item = Items.GetItemByName(this.TxtItemName.Text);
                this.NudItemId.Value = item.Id;
            }
        }
    }
}
